using System;

namespace MaternityWard
{
    enum WorkerRank
    {
        minor,
        senior,
        specialist,
        decisionMaker,
        manager,
        atRisk,
    };
    class Worker
    {
        const int HOURLY_WAGE_RATE = 100;
        const double MANAGER_SALARY = 123456789;

        protected WorkerRank[] ranks;
        Nullable<int> riskPercentage;
        double workHours;

        public WorkerRank[] Ranks
        {
            get { return ranks; }
            set { ranks = value; }
        }
        public double calculateSalary()
        {
            double raisedWorkHours = workHours;
            foreach (WorkerRank rank in ranks)
            {
                switch(rank)
                {
                    case WorkerRank.minor: continue;
                    case WorkerRank.senior:
                        raisedWorkHours *= 1.05;
                        break;
                    case WorkerRank.specialist:
                        raisedWorkHours *= 1.3;
                        break;
                    case WorkerRank.decisionMaker:
                        raisedWorkHours *= 1.5;
                        if (workHours > 50)
                        {
                            raisedWorkHours += 200;
                        }
                        break;
                    case WorkerRank.manager:
                        return MANAGER_SALARY;
                    case WorkerRank.atRisk:
                        if (riskPercentage.HasValue)
                        {
                            raisedWorkHours *= riskPercentage.Value;
                        }
                        break;
                }
            }
            return raisedWorkHours * HOURLY_WAGE_RATE;
        }
    }
}
