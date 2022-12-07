string num = Console.ReadLine();
int number;
bool success = int.TryParse(num, out number);
Console.WriteLine (success + " " + number);
if (num.Length != 5)
    {
    Console.WriteLine("неверный ввод");
    }
else
    if (num[0]==num[4] && num[1]==num[3])
    {
    Console.WriteLine("это палиндром");
    }
    else
    {
    Console.WriteLine("это не палиндром");
    }
