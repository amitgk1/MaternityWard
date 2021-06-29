namespace MaternityWard
{
    class ToxicCleaner : Cleaner
    {
        public ToxicCleaner() : base(getToxicCleanerRanks(), 20) { }

        static WorkerRank[] getToxicCleanerRanks()
        {
            return new WorkerRank[] { WorkerRank.decisionMaker, WorkerRank.manager, WorkerRank.atRisk };
        }
    }
}
