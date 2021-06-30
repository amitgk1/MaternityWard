namespace MaternityWard
{
    class BreechInternDoctor : InternDoctor
    {
        public BreechInternDoctor(string name) : base(name)
        {
            AddRank(new SpecialistRank());
        }
    }
}
