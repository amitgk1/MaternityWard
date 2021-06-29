namespace MaternityWard
{
    class SousChef : Cook
    {
        public SousChef(string name) : base(name, getSousChefRanks()) { }

        static IHourlyPaidRank[] getSousChefRanks()
        {
            return new IHourlyPaidRank[] { new SpecialistRank() };
        }
    }
}
