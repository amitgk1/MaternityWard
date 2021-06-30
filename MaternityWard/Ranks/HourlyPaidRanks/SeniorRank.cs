namespace MaternityWard
{
    class SeniorRank : IHourlyPaidRank
    {
        public double calculateSalary(double workHours)
        {
            return workHours * Config.HOURLY_WAGE * 1.05; // 5% increase
        }
    }
}
