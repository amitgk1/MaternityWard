using System.Collections.Generic;

namespace MaternityWard
{
    class FoodHander : AdministrativeWorker
    {
        public FoodHander(string name) : base(name)
        {
            List<object> foodHanderRanks = new List<object>();
            foodHanderRanks.Add(new MinorRank());
            Ranks = foodHanderRanks;
        }
    }
}
