namespace MaternityWard.AdministrativeWorkers.Cook
{
    class Cook : AdministrativeWorker
    {
        public Cook(WorkerRank[] ranks) : base(ranks: AddRankFirst(ranks, WorkerRank.senior)) { }
    }
}
