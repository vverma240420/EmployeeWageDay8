namespace EmployeeWageDay8
{
    internal class Program
    {
    

        public static void Main(string[] args)
        {
            Console.WriteLine("....EMP WAGE COMPUTATION....");

            //UC7-Use Class Method and Variables
            
            EmpWageForMultipleCompanies.EmpWage("HCL", 30, 16, 60);
            EmpWageForMultipleCompanies.EmpWage("TCS", 20, 15, 80);
            EmpWageForMultipleCompanies.EmpWage("BRIDGELAB", 15, 18, 100);
            Console.ReadLine();

        }
    }
}