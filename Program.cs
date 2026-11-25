// Пример
// string[] days = { "Пн", "Вт", "Ср", "Чт", "Пт" };

// for (int i = 0; i < days.Length; i++)
// {
//     Console.WriteLine($"{i}: {days[i]}");
// }

// Задание 1.1
// string[] week = { "Пн", "Вт", "Ср", "Чт", "Пт", "Сб", "Вс" };

// for (int i = week.Length - 1; i >= 0; i--)
// {
//     Console.WriteLine($"{i}: {week[i]}");
// }

// Задание 1.2
// double[] temps = { 3.5, -2, 0, 5.5, -7.5, 1, 4 };

// foreach (double t in temps)
// {
//     Console.Write($"{t} ");
// }
// Console.WriteLine();

// Задание 2
// int[] prices = { 120, 45, 300, 80, 15, 210 };
// int total = 0;
// int doroze = 0;

// foreach (int price in prices)
// {
//     total += price;
//     if (price > 100)
//     {
//         doroze++;
//     }
// }
// double averagePrice = (double)total / prices.Length;
// Console.WriteLine($"ообщая сумма: {total}");
// Console.WriteLine($"средняя цена: {averagePrice:F2}");
// Console.WriteLine($"товаров дороже 100: {doroze}");

// Задание 3
// int[] prices = { 120, 45, 300, 80, 15, 210 };
// int minPrice = prices[0];
// int maxIndex = 0;

// for (int i = 1; i < prices.Length; i++)
// {
//     if (prices[i] < minPrice)
//     {
//         minPrice = prices[i];
//     }
//     if (prices[i] > prices[maxIndex])
//     {
//         maxIndex = i;
//     }
// }

// Console.WriteLine($"мин цена: {minPrice}");
// Console.WriteLine($"индекс самого дорогого товара: {maxIndex}");

// Задание 4
// int[] balance = { 100, -50, 20, -5, 0, 75 };

// for (int i = 0; i < balance.Length; i++)
// {
//     if (balance[i] < 0)
//     {
//         balance[i] = 0;
//     }
// }

// foreach (int b in balance)
// {
//     Console.Write($"{b} ");
// }
// Console.WriteLine();

// Задание 5
// int[] nums = new int[5];

// for (int i = 0; i < nums.Length; i++)
// {
//     Console.Write($"введите число {i + 1} из {nums.Length}: ");
//     nums[i] = Convert.ToInt32(Console.ReadLine());
// }

// Console.WriteLine("массив в обратном порядке:");
// for (int i = nums.Length - 1; i >= 0; i--)
// {
//     Console.Write($"{nums[i]} ");
// }
// Console.WriteLine();

// int evenCount = 0;
// foreach (int x in nums)
// {
//     if (x % 2 == 0)
//     {
//         evenCount++;
//     }
// }
// Console.WriteLine($"четных чисел: {evenCount}");

// Задание 6
// string[] names = { "Анна", "Игорь", "Мария", "Олег", "Ольга" };
// Console.Write("Введите имя: ");
// string? name = Console.ReadLine();

// int position = -1;
// for (int i = 0; i < names.Length; i++)
// {
//     if (names[i] == name)
//     {
//         position = i;
//         break;
//     }
// }

// if (position == -1)
// {
//     Console.WriteLine("ненашли...");
// }
// else
// {
//     Console.WriteLine($"позиция в массиве: {position + 1} (индекс {position})");
// }

// Итоговая задача. Журнал оценок
int[] grades = { 5, 4, 3, 5, 2, 4, 5, 3 };

Console.WriteLine("ОЦЕНКИ:");
foreach (int g in grades)
{
    Console.Write($"{g} ");
}
Console.WriteLine();

int sum = 0;
int max = grades[0];
int min = grades[0];
int dvas = 0;
int fives = 0;

for (int i = 0; i < grades.Length; i++)
{
    sum += grades[i];
    if (grades[i] > max)
    {
        max = grades[i];
    }
    if (grades[i] < min)
    {
        min = grades[i];
    }
    if (grades[i] == 2)
    {
        dvas++;
    }
    if (grades[i] == 5)
    {
        fives++;
    }
}

double average = (double)sum / grades.Length;
Console.WriteLine($"средняя оценка: {average:F2}");
Console.WriteLine($"наибольшая: {max}, наименьшая: {min}");
Console.WriteLine($"двоечек: {dvas}, пятерочек: {fives}");

if (average >= 4.5)
{
    Console.WriteLine("отличник!!!!!!");
}
else if (average >= 3.5)
{
    Console.WriteLine("хорошист");
}
else
{
    Console.WriteLine("нсть над чем поработать..");
}