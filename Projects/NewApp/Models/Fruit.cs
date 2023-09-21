namespace NewApp.Models
{
    public class Fruit
    {
        public string TenHoaQua { get; set; }
        public string XuatXu { get; set; }
        public string HanSuDung { get; set; }
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
    }
}