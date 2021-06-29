namespace MaternityWard
{
    class MasterCleaner : AdministrativeWorker
    {
        public MasterCleaner() : base(ranks: getMasterCleanerRanks()) { }

        static WorkerRank[] getMasterCleanerRanks()
        {
            return new WorkerRank[] { WorkerRank.senior };
        }
    }
}
