namespace EmployeeWageDay8
{
    internal class Program
    {


        const int isFullTime = 1;
        const int isPartTime = 2;

        public static void Main(string[] args)
        {
            Console.WriteLine("....EMP WAGE COMPUTATION....");

            //UC7-Use Class Method and Variables
            //UC8-Multiple companies
            EmpWageBuilder Tata = new EmpWageBuilder("HCL", 30, 16, 60);
            EmpWageBuilder Google = new EmpWageBuilder("TCS", 20, 15, 80);
            EmpWageBuilder Apple = new EmpWageBuilder("BRIDGELAB", 15, 18, 100);

            Tata.EmpWage();
            Console.WriteLine(Tata.ToString());
            Google.EmpWage();
            Console.WriteLine(Apple.ToString());
            Apple.EmpWage();
            Console.WriteLine(Google.ToString());

            Console.ReadLine();

        }
    }
}
