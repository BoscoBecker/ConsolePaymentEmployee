using System.Xml.Linq;

namespace ConsolePaymentEmployee {

    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Informe a quantidade de funcionários: ");
            int quantidade = int.Parse(Console.ReadLine());
            string outSourced = "";
            Employee employee = new Employee();
            OutSourcedEmployee outSourcedEmployee = new OutSourcedEmployee();
            for (int i = 0; i < quantidade; i++)
            {
                Console.WriteLine($"Employee #{quantidade} data: ");
                Console.WriteLine("OutSourced (y/n): ");
                outSourced = Console.ReadLine();                
                Console.WriteLine("Your Name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Your Hour: ");
                int hour = int.Parse(Console.ReadLine());
                Console.WriteLine("Your Value per hour: ");
                double valueperhour = double.Parse(Console.ReadLine());

                if (outSourced == "y")
                {                    
                    outSourcedEmployee.valeuPerHour = valueperhour;
                    outSourcedEmployee.hours = hour;
                    outSourcedEmployee.name = name;
                    Console.WriteLine("Addtional Charge: ");
                    double addtionalCharge = double.Parse(Console.ReadLine());
                    outSourcedEmployee.addtionalCharge = addtionalCharge;
                    outSourcedEmployee.AddEmployee(outSourcedEmployee);
                } else
                {                    
                    outSourcedEmployee.valeuPerHour = valueperhour;
                    outSourcedEmployee.hours = hour;
                    outSourcedEmployee.name = name;
                    employee.AddEmployee(employee);
                }
            }
            Console.WriteLine("                  PAYMENTS                ");
            Console.WriteLine(employee.ToString());
            Console.WriteLine(outSourcedEmployee.ToString());

;
        }
    }
}