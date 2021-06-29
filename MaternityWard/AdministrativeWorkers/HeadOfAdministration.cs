namespace MaternityWard.AdministrativeWorkers.HeadOfAdministration
{
    class HeadOfAdministration : AdministrativeWorker
    {
        public HeadOfAdministration() : base(getHeadOfAdministrationRanks()) { }

        static WorkerRank[] getHeadOfAdministrationRanks()
        {
            return new WorkerRank[] { WorkerRank.manager, WorkerRank.decisionMaker };
        }
    }
}
