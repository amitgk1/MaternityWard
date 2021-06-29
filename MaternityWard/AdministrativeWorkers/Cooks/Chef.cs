namespace MaternityWard
{
    class Chef: Cook
    {
        public Chef(string name) : base(name, getChefRanks()) { }

        static IHourlyPaidRank[] getChefRanks()
        {
            return new IHourlyPaidRank[] { new SpecialistRank(), new DecisionMakerRank() };
        }
    }
}
