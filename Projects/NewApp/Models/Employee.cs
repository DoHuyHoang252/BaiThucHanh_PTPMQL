namespace NewApp.Models
{
    public class Employee
    {
        public string MaNhanVien { get; set; }
        public string TenNhanVien { get; set; }
        public int Tuoi { get; set; }
        public int LuongCoBan { get; set; }

        public Employee(){
            MaNhanVien = "2021050781";
            TenNhanVien = "Do Huy Hoang";
        }

        public void NhapThongTin(){
            System.Console.Write("Ma nhan vien: ");
            MaNhanVien = Console.ReadLine();
            System.Console.Write("Ten nhan vien: ");
            TenNhanVien = Console.ReadLine();
            System.Console.Write("Tuoi: ");
            Tuoi = Convert.ToInt32(Console.ReadLine());
            System.Console.Write("Luong co ban: ");
            LuongCoBan = Convert.ToInt32(Console.ReadLine());
        }
        public void HienThi(){
            System.Console.WriteLine(MaNhanVien + " - " + TenNhanVien + " - " + Tuoi + " - " + LuongCoBan);
        }

        public void HienThi(string TNV,int LCB){
            System.Console.WriteLine("Nhan vien {0} co muc luong co ban la {1}", TNV, LCB);
        }

        public int Luong(double hsl, int pc){
            return Convert.ToInt32(LuongCoBan * hsl + pc);
        }
    }
}