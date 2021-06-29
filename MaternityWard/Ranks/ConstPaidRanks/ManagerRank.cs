namespace MaternityWard
{
    class ManagerRank : IConstPaidRank
    {
        public double calculateSalary()
        {
            return Config.MANAGER_CONST_SALARY;
        }
    }
}
