namespace MaternityWard.ProfessionalWorkers.Midwife
{
    class Midwife : ProfessionalWorker
    {
        public Midwife(WorkerRank[] ranks) : base(ranks: AddRankFirst(ranks, WorkerRank.senior)) { }
    }
}
