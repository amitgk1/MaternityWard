namespace MaternityWard
{
    class MinorRank : IHourlyPaidRank
    {
        public double calculateSalary(double workHours)
        {
            return workHours * Config.HOURLY_WAGE;
        }
    }
}
