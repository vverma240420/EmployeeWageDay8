using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageDay8
{
    internal class CompanyEmpWage
    {
        public string company;
        public int empWagePerHr;
        public int empWorkinDaysPerMonth;
        public int empTotalWorkingHrs;
        public int empMontlyWage;
        public CompanyEmpWage(string company, int empWagePerHr, int empWorkinDaysPerMonth, int empTotalWorkingHrs)
        {
            this.company = company;
            this.empWagePerHr = empWagePerHr;
            this.empWorkinDaysPerMonth = empWorkinDaysPerMonth;
            this.empTotalWorkingHrs = empTotalWorkingHrs;
        }
        public void SetTotalEmpWage(int empMontlyWage)
        {
            this.empMontlyWage = empMontlyWage;
        }
        public override string ToString()
        {
            return "Company :" + this.company + " TotalWage =" + this.empMontlyWage;
        }
    }
}
