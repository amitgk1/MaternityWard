namespace MaternityWard
{
    class SpecialistDoctor : SeniorDoctor
    {
        public SpecialistDoctor(string name) : base(name)
        {
            AddRank(new SpecialistRank());
        }
    }
}
