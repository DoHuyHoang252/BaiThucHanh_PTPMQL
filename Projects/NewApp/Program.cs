Console.WriteLine("Do Huy Hoang - 2021050781");
Console.WriteLine("Nhap so thu nhat");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Nhap so thu hai");
int b = Convert.ToInt32(Console.ReadLine());
if(a == b){
    Console.WriteLine("{0} bang {1}", a, b);
} else {
    if(a > b) {
    Console.WriteLine("{0} lon hon {1}", a, b);
    } else Console.WriteLine("{0} nho hon {1}", a, b);
}