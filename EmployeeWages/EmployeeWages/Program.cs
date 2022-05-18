
namespace EmployeeWages
{
    public class Companies
    {
        public void EmpWage()
        {

        }
        public static void Main(string[] args)
        {
            EmployeeWageComputation empWageComputation = new EmployeeWageComputation(2);
            empWageComputation.AddCompany("TATA", 20, 8, 4, 100, 20);
            empWageComputation.CalculateEmpWage("tata");
            empWageComputation.AddCompany("MAHINDRA", 20, 8, 4, 100, 20);
            empWageComputation.CalculateEmpWage("mahindra");
            empWageComputation.AddCompany("Tesla", 60, 8, 7, 10, 200);
            empWageComputation.CalculateEmpWage("tesla");
            empWageComputation.ViewWage();

        }
    }
}


