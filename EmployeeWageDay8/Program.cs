namespace EmployeeWageDay8
{
    internal class Program
    {



        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Problem");
            //UC7-Use Class Method and Variables
            //UC8-Multiple companies
            IEmpWage builder = new EmpWageBuilder();

            builder.AddCompanyEmpWage("HCL", 30, 16, 60);
            builder.AddCompanyEmpWage("TCS", 20, 15, 80);
            builder.AddCompanyEmpWage("BRIDGELAB", 15, 18, 100);
            builder.IterateOverCompanies();
            Console.ReadLine();

        }
    }
}
