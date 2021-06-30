using System.Collections.Generic;

namespace MaternityWard
{
    class Cleaner : AdministrativeWorker
    {
        public Cleaner(string name) : base(name)
        {
            AddRank(new MinorRank());
        }
    }
}
