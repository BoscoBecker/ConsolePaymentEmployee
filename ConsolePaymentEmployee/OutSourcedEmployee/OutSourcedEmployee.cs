using System.Globalization;
using System.Text;

namespace ConsolePaymentEmployee
{
    class OutSourcedEmployee : Employee
    {
        public double addtionalCharge { get; set; }
        public List<OutSourcedEmployee> outSourcedEmployee = new List<OutSourcedEmployee>();

        public void AddEmployee(OutSourcedEmployee outSourcedEmployee)
        {
            this.employee.Add(outSourcedEmployee);
        }
        public override double CurrentBalance()
        {               
            return ((hours * valeuPerHour) * 1.1);
        }

        public override string ToString()
        {
            StringBuilder strutse = new StringBuilder();
            foreach (OutSourcedEmployee Outse in outSourcedEmployee) {
                strutse.Append("Name: " + Outse.name);
                strutse.Append(" - $"+Outse.CurrentBalance().ToString(CultureInfo.InvariantCulture));
            }
            return strutse.ToString();
        }
    }
}
