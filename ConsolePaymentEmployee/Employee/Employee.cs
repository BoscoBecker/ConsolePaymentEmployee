using System.Text;

namespace ConsolePaymentEmployee
{
    class Employee
    {
        public string? name { get; set; }
        public int hours { get; set; }
        public double valeuPerHour { get; set; }

        public List<Employee> employee = new List<Employee>();

     
        public virtual double CurrentBalance(){

            return (hours * valeuPerHour);
        }

        public Employee()
        {
        }

        public Employee(string? name, int hours, double valeuPerHour)
        {
            this.name = name;
            this.hours = hours;
            this.valeuPerHour = valeuPerHour;
        }

        public void AddEmployee(Employee employee) {
            this.employee.Add(employee);
        }

        public override string ToString()
        {
            StringBuilder stremployee = new StringBuilder();
            foreach (Employee emp in employee)
            {
                stremployee.Append("Name : " + emp.name);
                stremployee.Append(" - $ " + emp.CurrentBalance().ToString());
            }
            return stremployee.ToString();
        }
    }
}
