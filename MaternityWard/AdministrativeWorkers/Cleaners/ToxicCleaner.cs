namespace MaternityWard
{
    class ToxicCleaner : Cleaner
    {
        public ToxicCleaner(string name) : base(name)
        {
            RiskPercentage = 20;
            AddRank(new DecisionMakerRank());
            AddRank(new SpecialistRank());
        }
    }
}
