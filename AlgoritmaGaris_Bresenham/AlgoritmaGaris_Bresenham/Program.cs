float x0, y0, x1, y1, dX, dY;

Console.WriteLine("Algoritma Garis Bresenham");
Console.WriteLine("* Tentukan titik awal dan akhir");

Console.WriteLine("Titik awal");
Console.Write("Xawal = ");
x0 = Convert.ToInt64(Console.ReadLine());
Console.Write("Yawal = ");
y0 = Convert.ToInt64(Console.ReadLine());

Console.WriteLine("Titik akhir");
Console.Write("Xakhir = ");
x1 = Convert.ToInt64(Console.ReadLine());
Console.Write("Yakhir = ");
y1 = Convert.ToInt64(Console.ReadLine());

dX = x1 - x0;
dY = y1 - y0;

Console.WriteLine("* Tentukan nilai delta X & Y");
Console.WriteLine($@"dX = Xakhir - Xawal => {x1} - {x0} = {x1-x0}");
Console.WriteLine($@"dX = Yakhir - Yawal => {y1} - {y0} = {y1 - y0}");