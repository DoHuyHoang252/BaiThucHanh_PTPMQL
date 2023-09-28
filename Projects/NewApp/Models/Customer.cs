namespace NewApp.Models
{
    public class Customer : Person
    {
        public string CustomerID { get; set; }
        public string PhoneNumber { get; set; }

        public Customer(){
            CustomerID = "2021050781";
        }

        public void NhapThongTin(){
            base.NhapThongTin();
            System.Console.Write("Ma khach hang: ");
            CustomerID = Console.ReadLine();
            System.Console.Write("So dien thoai: ");
            PhoneNumber = Console.ReadLine();
        }
        public void HienThi(){
            base.HienThi();
            System.Console.Write(" - " + CustomerID + " - " + PhoneNumber);
        }
    }
}