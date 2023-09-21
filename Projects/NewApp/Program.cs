using System.Threading.Tasks.Dataflow;
using NewApp.Models;
public class Program{
    private static void Main(string[] args){
        Person ps1 = new Person();
        Student std = new Student();
        Employee emp = new Employee();
        Strawberry stb = new Strawberry();
        string ten = "Do Huy Hoang";
        int tuoi = 21;
        ps1.Display(ten, tuoi);
        System.Console.WriteLine("{0} sinh nam {1}", ten, ps1.GetYearOfBirthDay(tuoi));

        std.NhapThongTin();
        std.HienThi();

        emp.NhapThongTin();
        emp.HienThi();

        stb.NhapThongTin();
        stb.HienThi();
        stb.Message();
    }
}