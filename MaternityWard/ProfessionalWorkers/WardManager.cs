namespace MaternityWard
{
    class WardManager : ProfessionalWorker
    {
        public WardManager(string name) : base(name)
        {
            AddRank(new ManagerRank());
            AddRank(new DecisionMakerRank());
            RiskPercentage = 100;
        }
    }
}
