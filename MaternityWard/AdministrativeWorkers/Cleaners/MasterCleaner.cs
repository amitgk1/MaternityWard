namespace MaternityWard.AdministrativeWorkers.Cleaner.MasterCleaner
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
