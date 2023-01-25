// Принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

System.Console.Write("Введите число: ");
string input = Console.ReadLine();
char[] inputarray = input.ToCharArray();
Array.Reverse(inputarray);
string output = new string(inputarray);
if(input == output)
{
    System.Console.WriteLine($"{input} -> да");
}
if(input != output)
{
    System.Console.WriteLine($"{input} -> нет");
}

