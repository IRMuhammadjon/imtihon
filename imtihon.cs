
System.Console.WriteLine("1-Vazifa : Doira yuzi va aylana uzunligini hisoblash");
System.Console.WriteLine("Aylana radiusini kiriting : ");
double r = Convert.ToDouble( Console.ReadLine());
double pi=3.14;
double  L = r * pi * 2;
double S = pi* r *r ;
System.Console.WriteLine(S);
System.Console.WriteLine ($"Aylananing uzunligi {L} ga teng! ");
System.Console.WriteLine ($"Aylananing yuzasi  {S} ga teng! ");

System.Console.WriteLine("2-Vazifa : Valyuta konvertri");
System.Console.Write(" Qiymatni kiriting : ");
int  qiymat = Convert.ToInt32( System.Console.ReadLine());
System.Console.Write(" Kursni kiriting : ");
int  kurs = Convert.ToInt32( System.Console.ReadLine());
System.Console.WriteLine ($"{qiymat} dollor {qiymat * kurs } so'm bo'ladi ");

System.Console.WriteLine("3-Vazifa : Yoshni hisoblash");
System.Console.Write("Tug'ulgan yilingizini kiriting : ");
int x = Convert.ToInt32( System.Console.ReadLine());
System.Console.Write($"Siz kun yashadingiz : {((2023-x)*365)}\n"); 

