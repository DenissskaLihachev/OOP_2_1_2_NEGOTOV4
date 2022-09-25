/////////////////////////////// Task 1 ///////////////////////////////

//int N = 0, otric = 0;

//int[] mass;

//Console.Write("Введите размер массива: "); N = Convert.ToInt32(Console.ReadLine());

//mass = new int[N];

//for(int i = 0; i< N; i++)
//{
//    Console.Write($"Введите {i + 1}-й элемент массива: "); mass[i] = Convert.ToInt32(Console.ReadLine());
//}

//Console.Write("Ваш массив: [ ");
//foreach(var v in mass)
//{
//    Console.Write($"{v} ");
//    if (v < 0)
//        otric++;
//}
//Console.Write("]");

//if(otric < 2)
//    Console.WriteLine("\nСумма = 0");
//else
//{
//    Console.WriteLine("\nСумма = " + mass.SkipWhile(x => x < 0).Reverse().SkipWhile(x => x < 0).Sum());
//}


/////////////////////////////// Task 2 ///////////////////////////////

//Random rnd = new Random();

//int[][] mass = new int[10][];
//mass[0] = new int[1]; mass[1] = new int[2];
//mass[2] = new int[3]; mass[3] = new int[4];
//mass[4] = new int[5]; mass[5] = new int[6];
//mass[6] = new int[7]; mass[7] = new int[8];
//mass[8] = new int[9]; mass[9] = new int[10];


//foreach (var v in mass)                 //заполнение
//    for (var i = 0; i < v.Length; i++)
//        v[i] = rnd.Next(0, 10);


//foreach (int[] row in mass)  //вывод
//{
//    foreach (int number in row)                                                                       ПЕРЕДЕЛАТЬ СОРТИРОВКУ
//    {
//        Console.Write($"{number} \t");
//    }
//    Console.WriteLine();
//}

//for(int a = 0; a < 10; a++)
//{
//    foreach (var v in mass)      //сортировка
//    {
//        for (var i = 0; i < v.Length - 1; i++)
//        {
//            int temp = 0;
//            if (v[i] > v[i + 1])
//            {
//                temp = v[i];
//                v[i] = v[i + 1];
//                v[i + 1] = temp;
//            }
//        }
//    }
//}


//Console.WriteLine("\n\n");

//foreach (int[] row in mass)  //вывод
//{
//    foreach (int number in row)
//    {
//        Console.Write($"{number} \t");
//    }
//    Console.WriteLine();
//}

/////////////////////////////// Task 3 ///////////////////////////////


//int FOO(int[] mass, int choice)
//{
//    int res = 0;
//    switch (choice)
//    {
//        case 1:
//            {
//                foreach (var v in mass)
//                    if (v % 2 == 0)
//                        res++;
//                break;
//            }
//        case 2:
//            {
//                foreach (var v in mass)
//                    if (v % 2 != 0)
//                        res++;
//                break;
//            }
//    }
//    return res;
//}

//int[] mass = new int[] { 2, 5, 3, 1, 4, 8, 5, 9, 10, 7 }; //6 нечетных 4 четных

//Console.Write("1 - Четные\n2 - Нечетные\nВыбор: "); int choice = Convert.ToInt32(Console.ReadLine());

//int res = FOO(mass, choice);

//Console.Write($"\n\nОтвет: {res}\n\n");

/////////////////////////////// Task 4 ///////////////////////////////



//int FOO (in String text, out char symbol)
//{
//    symbol = default(char);
//    int legth = default(int);
//    int i = 0;

//    while (i < text.Length)
//    {
//        int length = 1;
//        while (i < text.Length && text[i].Equals(text[i+++1]))
//        {
//           length++;
//        }
//        int length_result = length;
//        if (length_result > legth)
//        {
//            symbol = text[i];
//            legth = length_result;
//        }
//        i += legth;
//    }
//    return legth;
//}

//String text = "asadddbbbbababaaaaaahhgg";

//char ch;
//int legth = FOO(text, out ch);

//Console.WriteLine($"Символ '{ch}' образует последовательность длиной в {legth} символов");

/////////////////////////////// Task 5 ///////////////////////////////

//void FOO(int[] mass, int sum)
//{
//    for (int a = 0; a < mass.Length; a++)
//    {
//        for (int b = 0; b < mass.Length - 1; b++)
//        {
//            if (mass[b] > mass[b + 1])
//            {
//                int z = mass[b];
//                mass[b] = mass[b + 1];
//                mass[b + 1] = z;
//            }
//        }
//    }

//    ////////////////////////////

//    int i = 0;
//    int j = mass.Length - 1;

//    int res = 0;

//    while (true)
//    {
//        res = mass[i] + mass[j];

//        if (res == sum)
//        {
//            Console.WriteLine($"Элемент 1-й: {mass[i]}\nЭлемент 2-й: {mass[j]}");
//            break;
//        }

//        if (i == j)
//        {
//            Console.WriteLine("РЕШЕНИЯ НЕТ!!!");
//            break;
//        }

//        j--;
//    }
//}

//int[] mass = new int[] { 1, 9, 5, 10, 2, 6, 3, 8, 4, 7 };

//Console.Write("Введите число: "); int sum = Convert.ToInt32(Console.ReadLine());

//FOO(mass, sum);