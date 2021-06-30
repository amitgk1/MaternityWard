namespace MaternityWard
{
    class HeadNurse : Nurse
    {
        public HeadNurse(string name) : base(name, new SeniorRank())
        {
            AddRank(new DecisionMakerRank());
        }
    }
}
