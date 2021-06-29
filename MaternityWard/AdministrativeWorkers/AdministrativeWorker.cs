namespace MaternityWard
{
    class AdministrativeWorker : Worker
    {

        public AdministrativeWorker(WorkerRank[] ranks, int? riskPercentage = null) : base(ranks, riskPercentage, "Administrative") { }
    }
}
