using System.Collections.Generic;

namespace MaternityWard
{
    class ShiftManagerCleaner : AdministrativeWorker
    {
        public ShiftManagerCleaner(string name) : base(name)
        {
            AddRank(new DecisionMakerRank());
        }
    }
}
