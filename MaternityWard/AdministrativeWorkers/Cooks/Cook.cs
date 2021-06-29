
using System.Collections.Generic;

namespace MaternityWard
{
    class Cook : AdministrativeWorker
    {
        public Cook(string name, IHourlyPaidRank[] extendedRanks = null) : base(name)
        {
            List<object> cookInitialRanks = new List<object>();
            cookInitialRanks.Add(new SeniorRank());
            if (extendedRanks != null)
            {
                foreach (IHourlyPaidRank rank in extendedRanks)
                {
                    cookInitialRanks.Add(rank);
                }
            }
            Ranks = cookInitialRanks;
        }
    }
}
