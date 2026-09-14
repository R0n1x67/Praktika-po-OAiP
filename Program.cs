using System;

//1 задание

//class Program
//{
//  static void Main()
//{
//  Console.Write("Фамилия: ");
//string surname = Console.ReadLine();

//Console.Write("Имя: ");
//string name = Console.ReadLine();

//Console.Write("Отчество: ");
//string patronymic = Console.ReadLine();

//Console.WriteLine($"{surname} {name[0]}. {patronymic[0]}.");

//}
//}


//2 задание

//class Program
//{
//  static void Main()
//{
//  Console.Write("Введите первое число: ");
//int a = int.Parse(Console.ReadLine());

//Console.Write("Введите второе число: ");
//int b = int.Parse(Console.ReadLine());

//Console.WriteLine($"Сумма: {a + b}");
//Console.WriteLine($"Разность: {a - b}");
//Console.WriteLine($"Произведение: {a * b}");
//Console.WriteLine($"Частное: {a / b}");
//Console.WriteLine($"Остаток: {a % b}");
//}
//}

//3 задание

//class Program
//{
//  static void Main()
//{
//  Console.Write("Введите температуру в градусах Цельсия: ");
//double c = double.Parse(Console.ReadLine());

//double f = c * 9 / 5 + 32;

//Console.WriteLine($"Температура по Фаренгейту: {f}");
//}
//}

//4 задание

//class Program
//{
// static void Main()
//{
//   Console.Write("Введите длину ребра куба: ");
//  double a = double.Parse(Console.ReadLine());

// double volume = a * a * a;
// double area = 6 * a * a;

// Console.WriteLine($"Объем куба: {volume}");
// Console.WriteLine($"Площадь полной поверхности: {area}");
// }
//}

//5 задание

//class Program
//{
//  static void Main()
// {
//    Console.Write("Введите количество секунд: ");
//  int seconds = int.Parse(Console.ReadLine());

//  int hours = seconds / 3600;
//int minutes = (seconds % 3600) / 60;
//int remainingSeconds = seconds % 60;

//Console.WriteLine($"{hours} ч, {minutes} мин, {remainingSeconds} сек");
//  }
//}

//6 задание

//class Program
//{
// static void Main()
// {
//    Console.Write("Введите a: ");
//   int a = int.Parse(Console.ReadLine());

//   Console.Write("Введите b: ");
//   int b = int.Parse(Console.ReadLine());

//   int temp = a;
//  a = b;
//  b = temp;

//   Console.WriteLine("Обмен 3 переменной: ");
//  Console.WriteLine($"a = {a}, b = {b}");

//  a = a + b;
//  b = a - b;
//   a = a - b;

//  Console.WriteLine("Обмен арифметикой: ");
//  Console.WriteLine($"a = {a}, b = {b}");
// }

//}

//7 задание

//class Program
//{
    //static void Main()
   //{
       //Console.Write("Введите первое число: ");
       //double a = double.Parse(Console.ReadLine());

        //Console.Write("Введите второе число: ");
       // double b = double.Parse(Console.ReadLine());

      //Console.Write("Введите третье число: ");
       //double c = double.Parse(Console.ReadLine());

       //double avg = (a + b + c) / 3;

        //Console.WriteLine($"Среднее арифметическое: {avg:F2}");
    //}
//}

//8 задание

//class Program
//{
//  static void Main()
//{
//  Console.Write("Введите расстояние в метрах: ");
//double distance = double.Parse(Console.ReadLine());

//        Console.Write("Введите время в секундах: ");
//      double time = double.Parse(Console.ReadLine());

//      double speed = distance / time * 3.6;

//    Console.WriteLine($"Скорость: {speed:F2} км/ч");
//}
//}

//9 задание

//class Program
//{
//static void Main()
// {
//    Console.Write("Введите стоимость товара: ");
//    decimal price = decimal.Parse(Console.ReadLine());

//   Console.Write("Введите процент скидки: ");
//   decimal discount = decimal.Parse(Console.ReadLine());

//  decimal discountAmount = price * discount / 100;
//   decimal finalPrice = price - discountAmount;

//  Console.WriteLine($"Сумма скидки: {discountAmount}");
//  Console.WriteLine($"Итоговая цена: {finalPrice}");
//}
//}

//10 задание

//class Program
//{
// static void Main()
//{
//   Console.Write("Введите баланс телефона: ");
//   decimal balance = decimal.Parse(Console.ReadLine());

//  Console.Write("Введите стоимость одной минуты: ");
//  decimal pricePerMinute = decimal.Parse(Console.ReadLine());

// decimal minutes = Math.Floor(balance / pricePerMinute);

// Console.WriteLine($"Доступно полных минут: {minutes}");
//  }
//}