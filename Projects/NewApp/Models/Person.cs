namespace NewApp.Models
{
    public class Person
    {
        public string FullName { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        public Person(){
            FullName = "Ho ten mac dinh";
            Address = "Dia chi mac dinh";
            Age = 20;
        }

        public void NhapThongTin(){
            System.Console.Write("Full name: ");
            FullName = Console.ReadLine();
            System.Console.Write("Address: ");
            Address = Console.ReadLine();
            System.Console.Write("Age: ");
            try
            {
                Age = Convert.ToInt32(Console.ReadLine());

            } catch {
                Age = 0;
            }
        }
        public void HienThi(){
            System.Console.Write("\n" + FullName + " - " + Address + " - " + Age);
        }
    }
}