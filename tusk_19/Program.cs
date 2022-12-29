//Напишите программу, которая принимает на вход пятизначное 
//число и проверяет, является ли оно палиндромом.

Console.Clear();

int getUser(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}

int palindrome(int number)
{
    int answer = -1;
    int n1 = number % 10;
    int n2 = number / 10000;
    if (n1 == n2)
    {
        int n3 = (number / 10) % 10;
        int n4 = (number / 1000) % 10;
        if (n3 == n4)
        {
             answer = 1;
        }
        else
        {
            answer = 0;
        }
    }
    else
    {
        answer = 0;
    }
    return answer;
}

int number = getUser("Введите пятизначное число: ");
int an = palindrome(number);
if (an == 1)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}