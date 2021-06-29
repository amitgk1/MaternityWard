using System.Collections.Generic;

namespace MaternityWard
{
    class HeadOfAdministration : AdministrativeWorker
    {
        public HeadOfAdministration(string name) : base(name)
        {
            List<object> foodHanderRanks = new List<object>();
            foodHanderRanks.Add(new ManagerRank());
            foodHanderRanks.Add(new DecisionMakerRank());
            Ranks = foodHanderRanks;
        }
    }
}