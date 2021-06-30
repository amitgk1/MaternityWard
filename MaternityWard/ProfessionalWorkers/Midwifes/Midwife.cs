namespace MaternityWard
{
    class Midwife : Nurse
    {
        public Midwife(string name) : base(name, new SeniorRank()) { }
    }
}
