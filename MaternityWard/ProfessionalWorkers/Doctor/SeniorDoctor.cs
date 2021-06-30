namespace MaternityWard
{
    class SeniorDoctor : ProfessionalWorker
    {
        public SeniorDoctor(string name) : base(name)
        {
            AddRank(new DecisionMakerRank());
        }
    }
}
