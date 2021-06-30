namespace MaternityWard
{
    class Doctor : ProfessionalWorker
    {
        public Doctor(string name) : base(name)
        {
            AddRank(new SeniorRank());
        }
    }
}
