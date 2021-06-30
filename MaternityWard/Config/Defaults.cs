using System;
using System.Collections;

namespace MaternityWard
{
    class Defaults
    {
        static ArrayList defaultWorkers = new ArrayList {
                    new Cleaner("Tal"),
                    new MasterCleaner("Moshe"),
                    new ShiftManagerCleaner("Tzahi"),
                    new ToxicCleaner("Avi"),
                    new Cook("Haim"),
                    new SousChef("Eyal"),
                    new Chef("Gordon"),
                    new FoodHander("Miri"),
                    new HeadOfAdministration("Matan"),
                    new Medic("Omer"),
                    new Paramedic("Tomer"),
                    new Nurse("Gili"),
                    new HeadNurse("Tzili"),
                    new Midwife("Sivan"),
                    new BreechMidwife("Jasmin"),
                    new InternDoctor("Ben"),
                    new BreechInternDoctor("Irad"),
                    new Doctor("Amit"),
                    new SeniorDoctor("Keren"),
                    new SpecialistDoctor("Yuval"),
                    new DeputyWardManager("Ariel"),
                    new WardManager("Daniel")
                };
        
        public static ArrayList getDefaultWorkers()
        {
            var rand = new Random();
            foreach (Worker worker in defaultWorkers)
            {
                worker.WorkHours = rand.NextDouble();
            }
            return defaultWorkers;
        }
    }
}
