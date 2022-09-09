/*


Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел 
больше 0 ввёл пользователь. Ввод чисел происходит через Enter, останавливается 
при введении слова "stop" 

int GetArr()
{
    Console.WriteLine("Введите числа через пробел (Stop для остановки)");
    int count = 0;
    for (int i = 0; ; i++)
    {
        string a = Console.ReadLine();
        if (a == "stop") break;
        else
        {
            int b = Convert.ToInt32(a);
            if (b > 0) count++;
        }
    }
    System.Console.WriteLine($"Введено {count} положительных чисел");
    return count;
}

GetArr();



Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.



string[] stringArray = Console.ReadLine().Split(' ');
double b1 = double.Parse(stringArray[0]);
double k1 = double.Parse(stringArray[1]);
double b2 = double.Parse(stringArray[2]);
double k2 = double.Parse(stringArray[3]);

double[] GetPoint(double b1, double k1, double b2, double k2){
    double[] result = new double[2];
    result[0] = (b2 - b1) / (k1 - k2);
    result[1] = k1 * result[0] + b1;

    return result;
}

System.Console.WriteLine(string.Join(" ", GetPoint(b1, k1, b2, k2)));


*/


