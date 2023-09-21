namespace NewApp.Models
{
    public class Person
    {
        public string FullName { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        public void NhapThongTin(){
            System.Console.Write("Full name: ");
            FullName = Console.ReadLine();
            System.Console.Write("Address: ");
            Address = Console.ReadLine();
            System.Console.Write("Age: ");
            Age = Convert.ToInt32(Console.ReadLine());
        }
        public void HienThi(){
            System.Console.WriteLine(FullName + " - " + Address + " - " + Age);
        }
    }
}