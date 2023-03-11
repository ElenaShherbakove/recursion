// Задача 64: Задайте значения N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// N = 5. -> "5, 4, 3, 2, 1"
// N = 8. -> "8, 7, 6, 5, 4, 3, 2, 1"

void RoadToN(int N, int count)

{
    if(count > N)
    {
        return;
    }
    RoadToN(N, count+1);
    System.Console.Write(count + " ");
}

System.Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 1;
RoadToN(number, count);

