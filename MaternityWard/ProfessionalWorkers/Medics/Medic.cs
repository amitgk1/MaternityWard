namespace MaternityWard
{
    class Medic : ProfessionalWorker
    {
        public Medic(string name) : base(name)
        {
            AddRank(new MinorRank());
        }
    }
}
