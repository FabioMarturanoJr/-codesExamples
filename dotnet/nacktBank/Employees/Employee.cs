namespace nacktBank.Employees
{
    public class Employee
    {
        public string? Name { get; set; }
        public string? CPF { get; set; }
        public int Salary { get; set; }
        
        public double GetBonus() {
            return Salary * 0.10;
        }
    }
}