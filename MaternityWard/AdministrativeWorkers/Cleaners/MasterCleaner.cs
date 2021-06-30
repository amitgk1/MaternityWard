using System.Collections.Generic;

namespace MaternityWard
{
    class MasterCleaner : AdministrativeWorker
    {
        public MasterCleaner(string name) : base(name)
        {
            AddRank(new SeniorRank());
        }
    }
}
