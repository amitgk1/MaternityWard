namespace MaternityWard
{
    class SpecialistRank : IHourlyPaidRank
    {
        public double calculateSalary(double workHours)
        {
            return workHours * Config.HOURLY_WAGE * 1.3; // 30% increase
        }
    }
}
