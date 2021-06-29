namespace MaternityWard.AdministrativeWorkers.FoodHander
{
    class FoodHander : AdministrativeWorker
    {
        public FoodHander() : base(getFoodHanderRanks()) { }

        static WorkerRank[] getFoodHanderRanks()
        {
            return new WorkerRank[] { WorkerRank.minor };
        }
    }
}
