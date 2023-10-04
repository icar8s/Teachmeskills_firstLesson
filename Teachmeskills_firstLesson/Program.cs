Console.WriteLine("Привет,как вас зовут");
var name = Console.ReadLine();
Console.WriteLine("Очень приятно " + name);
Console.WriteLine("Сейчас мы будем определять все четные числа в заданном тобой диапозоне");
Console.WriteLine("Введите первое число");
var a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число число");
var b = int.Parse(Console.ReadLine());
for (var i = a;i <= b; i++)
{
    if(i % 2 == 0)
    {
        Console.WriteLine(i);
    }
}
Console.ReadLine();