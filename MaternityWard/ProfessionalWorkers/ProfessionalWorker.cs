﻿namespace MaternityWard
{
    class ProfessionalWorker : Worker
    {
        public ProfessionalWorker(WorkerRank[] ranks, int? riskPercentage = null) : base(ranks, riskPercentage, "Professional") { }
    }
}