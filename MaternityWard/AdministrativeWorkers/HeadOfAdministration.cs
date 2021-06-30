using System.Collections.Generic;

namespace MaternityWard
{
    class HeadOfAdministration : AdministrativeWorker
    {
        public HeadOfAdministration(string name) : base(name)
        {
            AddRank(new ManagerRank());
            AddRank(new DecisionMakerRank());
        }
    }
}