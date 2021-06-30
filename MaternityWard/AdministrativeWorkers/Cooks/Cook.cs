
using System.Collections.Generic;

namespace MaternityWard
{
    class Cook : AdministrativeWorker
    {
        public Cook(string name) : base(name)
        {
            AddRank(new SeniorRank());
        }
    }
}
