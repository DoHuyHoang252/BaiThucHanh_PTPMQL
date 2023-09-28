using System.Collections;
using System.Runtime.Intrinsics.Arm;
using System.Threading.Tasks.Dataflow;
using NewApp.Models;
public class Program{
    private static void Main(string[] args){
        int n;
        Console.Write("Nhap kich thuoc mang Person: ");
        n = Convert.ToInt32(Console.ReadLine());
        Person[] psArr = new Person[n];
        
        for(int i = 0; i < psArr.Length; i++){
            Console.WriteLine("Nhap thong tin nguoi thu {0}", i+1);
            Person ps = new Person();
            ps.NhapThongTin();
            psArr[i] = ps;
        }
        Console.Write("Hien thi mang Person");
        foreach(Person ps in psArr){
            ps.HienThi();
        }
        Console.Write("\n" + "Nhap kich thuoc mang Student: ");
        n = Convert.ToInt32(Console.ReadLine());
        Student[] stdArr = new Student[n];
        for(int i = 0; i < stdArr.Length; i++){
            Console.WriteLine("Nhap thong tin sinh vien thu {0}", i+1);
            Student std = new Student();
            std.NhapThongTin();
            stdArr[i] = std;
        }
        Console.Write("Hien thi mang Student");
        foreach(Student std in stdArr){
            std.HienThi();
        }

        Console.Write("\n" + "Nhap kich thuoc mang Employee: ");
        n = Convert.ToInt32(Console.ReadLine());
        Employee[] empArr = new Employee[n];
        for(int i = 0; i < empArr.Length; i++){
            Console.WriteLine("Nhap thong tin nhan vien thu {0}", i+1);
            Employee emp = new Employee();
            emp.NhapThongTin();
            empArr[i] = emp;
        }
        Console.Write("Hien thi mang Employee");
        foreach(Employee emp in empArr){
            emp.HienThi();
        }

        Console.Write("\n" + "Nhap kich thuoc mang Customer: ");
        n = Convert.ToInt32(Console.ReadLine());
        Customer[] cusArr = new Customer[n];
        for(int i = 0; i < cusArr.Length; i++){
            Console.WriteLine("Nhap thong tin khach hang thu {0}", i+1);
            Customer cus = new Customer();
            cus.NhapThongTin();
            cusArr[i] = cus;
        }
        Console.Write("Hien thi mang Customer");
        foreach(Customer cus in cusArr){
            cus.HienThi();
        }
    }
}