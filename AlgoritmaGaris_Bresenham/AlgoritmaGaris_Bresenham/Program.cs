using AlgoritmaGaris_Bresenham.Object;

float x0, y0, x1, y1, dX, dY;
List<Kordinat> listKordinat = new List<Kordinat>();

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

Console.WriteLine("Hitung nilai P1 dengan kondisi :");

float p = 0;

listKordinat.Add(new Kordinat()
{
    X = x0,
    Y = y0
});

int iteration = 1;

if (dX > dY)
{
    p = (2 * dY) - dX;
    Console.WriteLine("Jika |dX| > |dY| maka");
    Console.WriteLine($@"P1 = 2dY - dX => {2 * dY} - {dX} = {(2 * dY) - dX}");
    Console.WriteLine("* Lalu lakukan perulangan hingga nilai X lebih dari nilai Xakhir");
    while (listKordinat.ToArray()[listKordinat.ToArray().Length - 1].X < x1)
    {
        Console.WriteLine($@"Iteration {iteration++}");
        if (p >= 0)
        {
            Console.WriteLine($@"Karena nilai P{iteration} >= 0 maka : ");
            Console.WriteLine($@"X{iteration} = X{iteration-1} + 1 => {listKordinat.ToArray()[listKordinat.ToArray().Length - 1].X} + 1 = {listKordinat.ToArray()[listKordinat.ToArray().Length - 1].X + 1}");
            Console.WriteLine($@"Y{iteration} = Y{iteration - 1} + 1 => {listKordinat.ToArray()[listKordinat.ToArray().Length - 1].Y} + 1 = {listKordinat.ToArray()[listKordinat.ToArray().Length - 1].Y + 1}");
            Console.WriteLine($@"P{iteration} = P{iteration} + (2.dY) - (2.dX) => {p} + 2.{dY} - 2.{dX} = {p + (2 * dY) - (2 * dX)}");
            
            listKordinat.Add(new Kordinat()
            {
                X = listKordinat.ToArray()[listKordinat.ToArray().Length - 1].X + 1,
                Y = listKordinat.ToArray()[listKordinat.ToArray().Length - 1].Y + 1
            });

            p = p + (2 * dY) - (2 * dX);
        }
        else {

            Console.WriteLine($@"Karena nilai P{iteration} < 0 maka : ");
            Console.WriteLine($@"X{iteration} = X{iteration - 1} + 1 => {listKordinat.ToArray()[listKordinat.ToArray().Length - 1].X} + 1 = {listKordinat.ToArray()[listKordinat.ToArray().Length - 1].X + 1}");
            Console.WriteLine($@"Y{iteration} = Y{iteration - 1} => {listKordinat.ToArray()[listKordinat.ToArray().Length - 1].Y}");
            Console.WriteLine($@"P{iteration} = P{iteration} + (2.dY) => {p} + 2.{dY} = {p + (2 * dY)}");

            listKordinat.Add(new Kordinat()
            {
                X = listKordinat.ToArray()[listKordinat.ToArray().Length - 1].X + 1,
                Y = listKordinat.ToArray()[listKordinat.ToArray().Length - 1].Y
            });

            p = p + (2 * dY);
        }   
    }    
}
else {
    Console.WriteLine("Jika |dX| < |dY| maka");
    Console.WriteLine($@"P1 = 2dX - dY => {2 * dX} - {dY} = {(2 * dX) - dY}");
    p = (2 * dX) - dY;
    if (p >= 0)
    {
        Console.WriteLine($@"Karena nilai P{iteration} >= 0 maka : ");
        Console.WriteLine($@"X{iteration} = X{iteration - 1} + 1 => {listKordinat.ToArray()[listKordinat.ToArray().Length - 1].X} + 1 = {listKordinat.ToArray()[listKordinat.ToArray().Length - 1].X + 1}");
        Console.WriteLine($@"Y{iteration} = Y{iteration - 1} + 1 => {listKordinat.ToArray()[listKordinat.ToArray().Length - 1].Y} + 1 = {listKordinat.ToArray()[listKordinat.ToArray().Length - 1].Y + 1}");
        Console.WriteLine($@"P{iteration} = P{iteration} + (2.dX) - (2.dY) => {p} + 2.{dX} - 2.{dY} = {p + (2 * dX) - (2 * dY)}");
        listKordinat.Add(new Kordinat()
        {
            X = listKordinat.ToArray()[listKordinat.ToArray().Length - 1].X + 1,
            Y = listKordinat.ToArray()[listKordinat.ToArray().Length - 1].Y + 1
        });

        p = p + (2 * dX) - (2 * dY);
    }
    else {
        Console.WriteLine($@"Karena nilai P{iteration} < 0 maka : ");
        Console.WriteLine($@"X{iteration} = X{iteration - 1} + 1 => {listKordinat.ToArray()[listKordinat.ToArray().Length - 1].X} + 1 = {listKordinat.ToArray()[listKordinat.ToArray().Length - 1].X + 1}");
        Console.WriteLine($@"Y{iteration} = Y{iteration - 1} => {listKordinat.ToArray()[listKordinat.ToArray().Length - 1].Y}");
        Console.WriteLine($@"P{iteration} = P{iteration} + (2.dX) => {p} + 2.{dX} = {p + (2 * dX)}");
        listKordinat.Add(new Kordinat()
        {
            X = listKordinat.ToArray()[listKordinat.ToArray().Length - 1].X,
            Y = listKordinat.ToArray()[listKordinat.ToArray().Length - 1].Y + 1
        });

        p = p + (2 * dX);
    }
}

Console.WriteLine($@"Result => {String.Join(",", listKordinat.Select(d => (d.X, d.Y)).ToArray())}");
