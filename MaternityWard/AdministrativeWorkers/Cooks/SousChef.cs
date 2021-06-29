namespace MaternityWard
{
    class SousChef : Cook
    {
        public SousChef() : base(getSousChefRanks()) { }

        static WorkerRank[] getSousChefRanks()
        {
            return new WorkerRank[] { WorkerRank.specialist };
        }
    }
}
