namespace EmployeeWageDay8
{
    internal class EmpWageBuilder
    {

        const int isFullTime = 1;
        const int isPartTime = 2;

        private string company;
        private int empWagePerHr;
        private int empWorkinDaysPerMonth;
        private int empTotalWorkingHrs;
        private int empMontlyWage;

        //UC9-Total Wage for each Company
        public EmpWageBuilder(string company, int empWagePerHr, int empWorkinDaysPerMonth, int empTotalWorkingHrs)
        {
            this.company = company;
            this.empWagePerHr = empWagePerHr;
            this.empWorkinDaysPerMonth = empWorkinDaysPerMonth;
            this.empTotalWorkingHrs = empTotalWorkingHrs;
        }
        public void EmpWage()
        {
            int empHrs = 0;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;

            //UC1- Employee Attendance
            Random random = new Random();
            //UC6-MaxHrs
            while (totalWorkingDays < empWorkinDaysPerMonth && totalEmpHrs < empTotalWorkingHrs)
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
            empMontlyWage = empWagePerHr * totalEmpHrs;
            Console.WriteLine("Total Number of Hours is  " + totalEmpHrs + ", Total Number of days is " + totalWorkingDays + ", Montly Wage of Emplyoee is " + empMontlyWage);
        }
        //UC10-ManageWageForMultipleCompanies
        public string ToString()
        {
            return "Company :" + this.company + " TotalWage =" + this.empMontlyWage;
        }
    }
}