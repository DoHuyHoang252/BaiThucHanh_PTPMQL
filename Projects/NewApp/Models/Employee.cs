namespace NewApp.Models
{
    public class Employee
    {
        public string MaNhanVien { get; set; }
        public string TenNhanVien { get; set; }
        public int Tuoi { get; set; }
        public int Luong { get; set; }
        public void NhapThongTin(){
            System.Console.Write("Ma nhan vien: ");
            MaNhanVien = Console.ReadLine();
            System.Console.Write("Ten nhan vien: ");
            TenNhanVien = Console.ReadLine();
            System.Console.Write("Tuoi: ");
            Tuoi = Convert.ToInt32(Console.ReadLine());
            System.Console.Write("Luong: ");
            Luong = Convert.ToInt32(Console.ReadLine());
        }
        public void HienThi(){
            System.Console.WriteLine(MaNhanVien + " - " + TenNhanVien + " - " + Tuoi + " - " + Luong);
        }
    }
}