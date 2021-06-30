namespace MaternityWard
{
    class SousChef : Cook
    {
        public SousChef(string name) : base(name)
        {
            AddRank(new SpecialistRank());
        }
    }
}
