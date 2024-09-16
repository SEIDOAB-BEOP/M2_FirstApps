// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

long area, circumference;
double diagonal;

GetACD(1,1, out area,out circumference, out diagonal);
System.Console.WriteLine($"area: {area} circumference: {circumference} diagonal: {diagonal}");


GetACD(2,2, out area,out circumference, out diagonal);
System.Console.WriteLine($"area: {area} circumference: {circumference} diagonal: {diagonal}");


(long, long, double) res = GetACD1(2, 2);
System.Console.WriteLine($" area: {res.Item1} circumference: {res.Item2} diagonal: {res.Item3}");

(long area, long circumference, double diagonal) res1 = GetACD1(2, 2);
System.Console.WriteLine($" area: {res1.area} circumference: {res1.circumference} diagonal: {res1.diagonal}");


static void GetACD(long width, long height,
    out long area, out long circumference, out double diagonal)
{
    area = width * height;
    circumference = 2 * width + 2 * height;
    diagonal = Math.Sqrt(width * width + height + height);
}

static (long, long, double) GetACD1(long width, long height)
{
    var area = width * height;
    var circumference = 2 * width + 2 * height;
    var diagonal = Math.Sqrt(width * width + height + height);

    return (area, circumference, diagonal);
}
