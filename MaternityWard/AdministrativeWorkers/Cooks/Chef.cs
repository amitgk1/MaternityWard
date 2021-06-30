namespace MaternityWard
{
    class Chef: Cook
    {
        public Chef(string name) : base(name)
        {
            AddRank(new SpecialistRank());
            AddRank(new DecisionMakerRank());
        }
    }
}
