namespace MaternityWard
{
    class InternDoctor : ProfessionalWorker
    {
        public InternDoctor(string name) : base(name)
        {
            AddRank(new MinorRank());
        }
    }
}
