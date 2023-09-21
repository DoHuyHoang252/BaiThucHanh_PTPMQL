namespace NewApp.Models
{
    public class Employee : Person
    {
        public string EmployeeID { get; set; }
        public int SalaryBasic { get; set; }

        public Employee(){
            EmployeeID = "2021050781";
        }

        public void NhapThongTin(){
            base.NhapThongTin();
            System.Console.Write("Ma nhan vien: ");
            EmployeeID = Console.ReadLine();
            System.Console.Write("Luong co ban: ");
            SalaryBasic = Convert.ToInt32(Console.ReadLine());
        }
        public void HienThi(){
            base.HienThi();
            System.Console.WriteLine(" - " + EmployeeID + " - " + SalaryBasic);
        }

        public void HienThi(string TNV,int LCB){
            System.Console.WriteLine("Nhan vien {0} co muc luong co ban la {1}", TNV, LCB);
        }

        public int Luong(double hsl, int pc){
            return Convert.ToInt32(SalaryBasic * hsl + pc);
        }
    }
}