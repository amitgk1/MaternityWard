namespace MaternityWard
{
    class ToxicCleaner : Cleaner
    {
        public ToxicCleaner(string name) : base(name, getToxicCleanerRanks())
        {
            RiskPercentage = 20;
        }

        static IHourlyPaidRank[] getToxicCleanerRanks()
        {
            return new IHourlyPaidRank[] { new DecisionMakerRank(), new SpecialistRank()};
        }
    }
}
