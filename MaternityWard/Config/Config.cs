using System.Collections.Specialized;

namespace MaternityWard
{
    class Config
    {
        public static int HOURLY_WAGE = 100;
        public static int MANAGER_CONST_SALARY = 1000;
        public static OrderedDictionary AdministrativeWorkersMap = new OrderedDictionary() {
            { "cleaner", typeof(Cleaner) },
            { "master cleaner", typeof(MasterCleaner) },
            { "shift manager cleaner", typeof(ShiftManagerCleaner) },
            { "toxic cleaner", typeof(ToxicCleaner) },
            { "cook", typeof(Cook) },
            { "sous chef", typeof(SousChef) },
            { "chef", typeof(Chef) },
            { "food hander", typeof(FoodHander) },
            { "head of Administration", typeof(HeadOfAdministration) },
        };

        public static OrderedDictionary ProfessionalWorkersMap = new OrderedDictionary() {
            { "medic", typeof(Medic) },
            { "paramedic", typeof(Paramedic) },
            { "nurse", typeof(Nurse) },
            { "head nurse", typeof(HeadNurse) },
            { "midwife", typeof(Midwife) },
            { "breech birth midwife", typeof(BreechMidwife) },
            { "intern doctor", typeof(InternDoctor) },
            { "breech birth intern", typeof(BreechInternDoctor) },
            { "doctor", typeof(Doctor) },
            { "senior doctor", typeof(SeniorDoctor) },
            { "specialist doctor", typeof(SpecialistDoctor) },
            { "deputy ward manager", typeof(DeputyWardManager) },
            { "ward manager", typeof(WardManager) },
        };
    }
}
