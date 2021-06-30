using System;
using System.Collections;
using System.Collections.Specialized;

namespace MaternityWard
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome!");
            ArrayList workers = new ArrayList();

            int actionType = 0;
            while (actionType != 9)
            {
                Console.WriteLine("Enter What You would like to do:");
                Console.WriteLine("1 for entering workers, 2 for entering hours for the exisiting, 3 for getting a worker salary, 9 to stop");
                actionType = Convert.ToInt32(Console.ReadLine());
                switch (actionType)
                {
                    case 1:
                        inputWorkers(ref workers);
                        break;
                    case 2:
                        foreach (Worker worker in workers)
                        {
                            Console.WriteLine($"Enter start and end hours for {getWorkerJobAndName(worker)}");
                            Console.WriteLine("start hour:");
                            TimeSpan startHour = GetTimeInput();
                            Console.WriteLine("end hour:");
                            TimeSpan endHour = GetTimeInput();
                            worker.WorkHours += endHour.Subtract(startHour).TotalHours;
                        }
                        break;
                    case 3:
                        if (workers.Count > 0)
                        {
                            Console.WriteLine("INDEX");
                            for (int i = 0; i < workers.Count; i++)
                            {
                                Console.WriteLine("{0,-5} {1,-25}", i, getWorkerJobAndName(workers[i] as Worker));
                            }
                            Console.WriteLine("Enter the index of the worker you want to check his salary: ");
                            int index = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine($"Total salary is: {(workers[index] as Worker).getTotalSalary()}");
                        }
                        else
                        {
                            Console.WriteLine("no workers yet... press 1 to load defaults or input yourself\n");
                        }
                        break;
                    case 9:
                        continue;
                    default:
                        Console.WriteLine("bad input - try again");
                        break;
                }
            }
        }

        public static string getWorkerJobAndName(Worker worker)
        {
            string job = worker.ToString().Split(".")[1];
            return $"{job}: {worker.Name}";
        }

        public static void DisplayDictKeys(OrderedDictionary dict)
        {
            string[] keys = new string[dict.Count];
            dict.Keys.CopyTo(keys, 0);
            Console.WriteLine("INDEX KEY");
            for (int i = 0; i < dict.Count; i++)
            {
                Console.WriteLine("{0,-5} {1,-25}", i, keys[i]);
            }
        }

        public static TimeSpan GetTimeInput()
        {
            Console.WriteLine("Enter hour in the format: HH:MM");
            string enteredHour = Console.ReadLine();
            TimeSpan parsedHour;
            if (TimeSpan.TryParse(enteredHour, out parsedHour))
            {
                return parsedHour;
            }
            else
            {
                throw new Exception($"cannot parse the given hour: {enteredHour}, should be in HH:MM format");
            }
        }

        public static void inputWorkers(ref ArrayList workers)
        {
            Console.WriteLine("Would you like to use the default workers list or enter a few yourself?");
            Console.WriteLine("1 - default\n2 - yourself");
            string action = Console.ReadLine();
            if (action == "1")
            {
                workers = Defaults.getDefaultWorkers();
                return;
            }
            else if (action == "2")
            {
                while (action != "9")
                {
                    Console.WriteLine("Would you like to enter Administrative or Professional workers?");
                    Console.WriteLine("1 - Administrative\n2 - Professional\nor 9 to stop");
                    action = Console.ReadLine();
                    OrderedDictionary dict;
                    if (action == "1")
                    {
                        dict = Config.AdministrativeWorkersMap;
                    }
                    else if (action == "2")
                    {
                        dict = Config.ProfessionalWorkersMap;
                    }
                    else
                    {
                        Console.WriteLine("bad input - try again");
                        continue;
                    }
                    DisplayDictKeys(dict);
                    Console.WriteLine("Enter the index of the worker you want to create: ");
                    int index = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the name of the worker: ");
                    string name = Console.ReadLine();
                    Type[] values = new Type[dict.Values.Count];
                    dict.Values.CopyTo(values, 0);
                    Worker newWorker = values[index].GetConstructors()[0].Invoke(new object[] { name }) as Worker;
                    workers.Add(newWorker);
                }
            }
            else
            {
                Console.WriteLine("Bad Input - try again later");
            }
        }
    }
}
