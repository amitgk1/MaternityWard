namespace MaternityWard
{
    class Cleaner : AdministrativeWorker
    {
        public Cleaner(WorkerRank[] ranks, int? riskPercentage = null) : base(ranks: AddRankFirst(ranks, WorkerRank.minor), riskPercentage) { }
    }
}
