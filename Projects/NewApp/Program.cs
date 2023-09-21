using System.Threading.Tasks.Dataflow;
using NewApp.Models;
public class Program{
    private static void Main(string[] args){
        GiaiPhuongTrinh phuongtrinhbac1 = new GiaiPhuongTrinh();
        GiaiPhuongTrinh phuongtrinhbac2 = new GiaiPhuongTrinh();
        string ketqua = phuongtrinhbac1.PhuongTrinhBacNhat(1,2);
        System.Console.WriteLine(ketqua);
        ketqua = phuongtrinhbac2.PhuongTrinhBacHai(1,4,4);
        System.Console.WriteLine(ketqua);
    }
}