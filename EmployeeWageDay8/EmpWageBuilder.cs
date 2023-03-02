namespace EmployeeWageDay8
{
    internal class EmpWageBuilder : IEmpWage
    {
        const int isFullTime = 1;
        const int isPartTime = 2;
        public int numOfCompanies = 0;
        public CompanyEmpWage[] companies;
        //UC10-EmpWageArray-ManageWageForMultipleCompanies
        //UC9-Total Wage for each Company
        public EmpWageBuilder()
        {
            companies = new CompanyEmpWage[3];
        }
        void IEmpWage.AddCompanyEmpWage(string company, int empWagePerHr, int empWorkinDaysPerMonth, int empTotalWorkingHrs)
        {
            CompanyEmpWage companyEmpWage = new CompanyEmpWage(company, empWagePerHr, empWorkinDaysPerMonth, empTotalWorkingHrs);
            companies[numOfCompanies] = companyEmpWage;
            numOfCompanies++;
        }
        void IEmpWage.IterateOverCompanies()
        {
            for (int i = 0; i < companies.Length; i++)
            {
                companies[i].SetTotalEmpWage(EmpWage(companies[i]));
                Console.WriteLine(this.companies[i].ToString());
            }
        }
        public int EmpWage(CompanyEmpWage companyEmpWage)
        {
            int empHrs = 0;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;

            //UC1- Employee Attendance
            Random random = new Random();
            //UC6-MaxHrs
            while (totalWorkingDays < companyEmpWage.empWorkinDaysPerMonth && totalEmpHrs < companyEmpWage.empTotalWorkingHrs)
            {
                int empAttendance = random.Next(0, 3);
                //UC3- Add Part Time Employee
                //UC4- Switch Case
                switch (empAttendance)
                {
                    case isFullTime:
                        empHrs = 8;
                        break;
                    case isPartTime:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalWorkingDays++;
                totalEmpHrs += empHrs;
            }
            //UC2- Employee Daily Wage
            //UC5- Employee Monthly Wage
            companyEmpWage.empMontlyWage = companyEmpWage.empWagePerHr * totalEmpHrs;
            return companyEmpWage.empMontlyWage;
        }
    }
}