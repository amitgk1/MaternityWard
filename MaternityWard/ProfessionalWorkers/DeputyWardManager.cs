namespace MaternityWard
{
    class DeputyWardManager : ProfessionalWorker
    {
        public DeputyWardManager(string name) : base(name)
        {
            AddRank(new ManagerRank());
            AddRank(new DecisionMakerRank());
        }
    }
}
