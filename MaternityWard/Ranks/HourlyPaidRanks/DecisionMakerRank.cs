namespace MaternityWard
{
    class DecisionMakerRank : IHourlyPaidRank
    {
        public double calculateSalary(double workHours)
        {
            double salary = workHours * Config.HOURLY_WAGE * 1.5; // 50% increase
            if (workHours > 50)
            {
                salary += 200 * Config.HOURLY_WAGE;
            }
            return salary;
        }
    }
}
