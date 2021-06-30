namespace MaternityWard
{
    class Paramedic : ProfessionalWorker
    {
        public Paramedic(string name) : base(name)
        {
            AddRank(new MinorRank());
        }
    }
}
