using System.Collections.Generic;

namespace MaternityWard
{
    class FoodHander : AdministrativeWorker
    {
        public FoodHander(string name) : base(name)
        {
            AddRank(new MinorRank());
        }
    }
}
