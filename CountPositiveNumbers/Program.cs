// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3 (ошибка в примере, здесь должно быть число 4)

string GetNumbersFromUser(string text, int count)
{
    string numbers = "";
    int calc = 0;
    for (int i = 0; i < count; i++)
    {
        double value = double.Parse(Console.ReadLine());
        if (value > 0) calc++;
    }
    numbers += calc;
    return numbers;
}
Console.WriteLine("Введите, пожалуйста, 10 чисел, а я подскажу, сколько из них являются положительными");
string s = GetNumbersFromUser("Введите, пожалуйста, число", 10);
Console.WriteLine(s);
