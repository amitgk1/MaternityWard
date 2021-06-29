using System;

namespace MaternityWard
{
    class Worker
    {
        int? riskPercentage;
        object[] ranks;

        public string Type
        { get; set; }

        public string Name
        { get; set; }

        public double WorkHours
        { get; set; }

        public Worker(string type, string name)
        {
            Type = type;
            Name = name;
        }

        public object[] Ranks
        {
            get { return ranks; }
            set
            {
                foreach (object rank in value)
                {
                    if (rank is IHourlyPaidRank || rank is IConstPaidRank)
                    {
                        ranks[ranks.Length] = rank;
                    }
                    else
                    {
                        throw new Exception("rank should be one the types: IHourlyPaidRank, IConstPaidRank");
                    }
                }
            }
        }

        public int? RiskPercentage
        {
            get { return riskPercentage; }
            set
            {
                if (value >= 1 && value <= 100)
                {
                    riskPercentage = value;
                }
                else
                {
                    throw new Exception("risk percentage must be a number between 1 and 100");
                }
            }
        }

        public double getTotalSalary()
        {
            double salary = 0;
            foreach (object rank in ranks)
            {
                if (rank is IHourlyPaidRank)
                {
                    salary += (rank as IHourlyPaidRank).calculateSalary(WorkHours);
                }
                else
                {
                    salary += (rank as IConstPaidRank).calculateSalary();
                }
            }
            return salary;
        }
    }
}
