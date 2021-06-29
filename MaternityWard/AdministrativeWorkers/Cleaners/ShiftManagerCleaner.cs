using System.Collections.Generic;

namespace MaternityWard
{
    class ShiftManagerCleaner : AdministrativeWorker
    {
        public ShiftManagerCleaner(string name) : base(name)
        {
            List<object> shiftManagerCleaner = new List<object>();
            shiftManagerCleaner.Add(new SeniorRank());
            Ranks = shiftManagerCleaner;
        }
    }
}
