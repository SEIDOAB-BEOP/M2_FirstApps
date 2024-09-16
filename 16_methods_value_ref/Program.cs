// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var a1 = 2L;
var a2 = 2L;

var area1 = AreaVal(a1, a2);
System.Console.WriteLine($"Area {area1}, a2 = {a2}");

var rect = new Rect(){width = 2, height= 2};
var area2 = AreaRef(rect);
System.Console.WriteLine($"Area {area2}, width: {rect.width}");

static long AreaRef(Rect rectparam)
{
    var area = rectparam.width * rectparam.height;
    rectparam.width = 100;
    return area;
}

static long AreaVal(long width, long height)
{

    var area = width * height;

    width = 100;
    return area;
}

class Rect 
{
    public long width;
    public long height;
}

