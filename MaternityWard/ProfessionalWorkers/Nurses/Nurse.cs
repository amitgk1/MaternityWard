namespace MaternityWard
{
    class Nurse : ProfessionalWorker
    {
        public Nurse(string name, IHourlyPaidRank baseRank = null) : base(name)
        {
            MinorRank defaultBaseRank = new MinorRank();
            if (baseRank != null)
            {
                AddRank(baseRank);
            }
            else
            {
                AddRank(defaultBaseRank);
            }
        }
    }
}
