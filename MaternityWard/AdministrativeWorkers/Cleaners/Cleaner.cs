using System.Collections.Generic;

namespace MaternityWard
{
    class Cleaner : AdministrativeWorker
    {
        public Cleaner(string name, IHourlyPaidRank[] extendedRanks = null) : base(name)
        {
            List<object> cleanerInitialRanks = new List<object>();
            cleanerInitialRanks.Add(new MinorRank());
            if (extendedRanks != null)
            {
                foreach (IHourlyPaidRank rank in extendedRanks)
                {
                    cleanerInitialRanks.Add(rank);
                }
            }
            Ranks = cleanerInitialRanks;
        }
    }
}
