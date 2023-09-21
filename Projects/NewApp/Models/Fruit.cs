namespace NewApp.Models
{
    public class Fruit
    {
        public string TenHoaQua { get; set; }
        public string XuatXu { get; set; }
        public string HanSuDung { get; set; }

        public Fruit(){
            TenHoaQua = "Xoai";
            XuatXu = "VietNam";
            HanSuDung = "20/09/2023";
        }

        public void NhapThongTin(){
            System.Console.Write("Ten hoa qua: ");
            TenHoaQua = Console.ReadLine();
            System.Console.Write("Xuat xu: ");
            XuatXu = Console.ReadLine();
            System.Console.Write("Han su dung: ");
            HanSuDung = Console.ReadLine();
        }
        public void HienThi(){
            System.Console.WriteLine(TenHoaQua + " - " + XuatXu + " - " + HanSuDung);
        }
        public void HienThi(string THQ, string XX){
            System.Console.WriteLine("{0} co xuat xu tu {1}", THQ, XX);
        }
        public string LayXuatXu(){
            return XuatXu;
        }
    }
}