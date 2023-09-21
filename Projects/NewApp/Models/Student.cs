namespace NewApp.Models
{
    public class Student
    {
        public string HoTen { get; set; }
        public string DiaChi { get; set; }
        public int Tuoi { get; set; }
        public string SoDienThoai { get; set; }
        public void NhapThongTin(){
            System.Console.Write("Ho ten sinh vien: ");
            HoTen = Console.ReadLine();
            System.Console.Write("Dia chi: ");
            DiaChi = Console.ReadLine();
            System.Console.Write("Tuoi: ");
            Tuoi = Convert.ToInt32(Console.ReadLine());
            System.Console.Write("So dien thoai: ");
            SoDienThoai = Console.ReadLine();
        }
        public void HienThi(){
            System.Console.WriteLine(HoTen + " - " + DiaChi + " - " + Tuoi + " - " + SoDienThoai);
        }
    }
}