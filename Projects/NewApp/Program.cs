using System.Threading.Tasks.Dataflow;
using NewApp.Models;
public class Program{
    private static void Main(string[] args){
        Person ps1 = new Person();
        Student std = new Student();
        Employee emp = new Employee();
        Fruit fr = new Fruit();
        string ten = "Do Huy Hoang";
        int tuoi = 21;
        ps1.Display(ten, tuoi);
        System.Console.WriteLine("{0} sinh nam {1}", ten, ps1.GetYearOfBirthDay(tuoi));

        string TenSV = "Do Huy Hoang";
        string SDT = "0396987532";
        std.HienThi(TenSV, SDT);
        System.Console.WriteLine("Sinh vien {0} co nam sinh la {1}", std.HoTen, std.NamSinh());

        string TenNV = "Do Huy Hoang";
        int luongcb = 2500000;
        double hesoluong = 2.5;
        int phucap = 1000000;
        emp.HienThi(TenNV, luongcb);
        emp.LuongCoBan = 5000000;
        System.Console.WriteLine("Nhan vien {0} co luong la {1}", emp.TenNhanVien, emp.Luong(hesoluong, phucap));

        string tenhoaqua = "Tao";
        string xuatxu = "Trung Quoc";
        fr.HienThi(tenhoaqua, xuatxu);
        System.Console.WriteLine("{0} co xuat xu tu {1}", fr.TenHoaQua,fr.LayXuatXu());
    }
}