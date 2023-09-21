namespace NewApp.Models
{
    public class Student : Person
    {
        public string StudentCode {get; set;}

        public void NhapThongTin(){
            base.NhapThongTin();
            System.Console.Write("Ma Sinh Vien: ");
            StudentCode = Console.ReadLine();
        }
        public void HienThi(){
            base.HienThi();
            System.Console.WriteLine("-Ma sinh vien: {0}", StudentCode);
        }
        public void HienThi(string HT, string SDT){
            System.Console.WriteLine("Sinh vien {0} co so dien thoai la {1}", HT, SDT);
        }
        public int NamSinh(){
            return 2023 - Age;
        }
    }
}