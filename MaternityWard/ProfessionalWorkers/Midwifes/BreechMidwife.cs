namespace MaternityWard
{
    class BreechMidwife : Nurse
    {
        public BreechMidwife(string name) : base(name, new SeniorRank()) 
        {
            AddRank(new SpecialistRank());
        }
    }
}
