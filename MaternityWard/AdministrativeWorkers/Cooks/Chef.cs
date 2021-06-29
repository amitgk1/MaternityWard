namespace MaternityWard
{
    class Chef: Cook
    {
        public Chef() : base(getChefRanks()) { }

        static WorkerRank[] getChefRanks()
        {
            return new WorkerRank[] { WorkerRank.specialist, WorkerRank.decisionMaker };
        }
    }
}
