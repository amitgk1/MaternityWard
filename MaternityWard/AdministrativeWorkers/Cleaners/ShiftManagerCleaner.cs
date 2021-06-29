namespace MaternityWard.AdministrativeWorkers.Cleaner.ShiftManagerCleaner
{
    class ShiftManagerCleaner : AdministrativeWorker
    {
        public ShiftManagerCleaner() : base(getShiftManagerCleanerRanks()) { }

        static WorkerRank[] getShiftManagerCleanerRanks()
        {
            return new WorkerRank[] { WorkerRank.decisionMaker };
        }
    }
}
