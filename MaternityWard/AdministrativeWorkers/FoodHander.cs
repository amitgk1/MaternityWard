namespace MaternityWard
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
