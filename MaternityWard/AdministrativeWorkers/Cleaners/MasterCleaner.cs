using System.Collections.Generic;

namespace MaternityWard
{
    class MasterCleaner : AdministrativeWorker
    {
        public MasterCleaner(string name) : base(name)
        {
            List<object> masterCleanerRanks = new List<object>();
            masterCleanerRanks.Add(new SeniorRank());
            Ranks = masterCleanerRanks;
        }
    }
}
