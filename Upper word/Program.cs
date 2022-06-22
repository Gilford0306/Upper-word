//Задание 6
//Пользователь с клавиатуры вводит некоторый текст. 
//Приложение должно изменять регистр первой буквы 
//каждого предложения на букву в верхнем регистре.
Console.WriteLine("Input string");
string m = Console.ReadLine();
string[] words = m.Split(new char[] { '.' });
for (int i = 0; i < words.Length; i++)
{
    string temp = words[i];
    for (int j = 0; j < temp.Length; j++)
    {
        if (Char.IsLetter(temp[j]))
        {
            if (j > 0)
            {
                temp = temp.Substring(0, j)+ char.ToUpper(temp[j]) + temp.Substring(j + 1);
                break;
            }
            temp = char.ToUpper(temp[j]) + temp.Substring(j+1);
            break;
        }
    }
    if (i == (words.Length - 1))
    { 
        Console.Write(temp);
        return;
    }
    Console.Write(temp+".");
}