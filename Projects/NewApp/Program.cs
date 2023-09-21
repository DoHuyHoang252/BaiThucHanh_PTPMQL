using NewApp.Models;
public class Program{
    private static void Main(string[] args){
        Person ps1 = new Person();
        Person ps2 = new Person();
        Student std = new Student();
        Employee emp = new Employee();
        Fruit fr = new Fruit();
        ps1.FullName = "Do Huy Hoang";
        ps1.Address = "Ha Noi";
        ps1.Age = 18;
        ps1.HienThi();
        ps2.NhapThongTin();
        ps2.HienThi();
        std.NhapThongTin();
        std.HienThi();
        emp.NhapThongTin();
        emp.HienThi();
        fr.NhapThongTin();
        fr.HienThi();
    }
}