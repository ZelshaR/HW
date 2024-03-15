// Первый номер

// int m = -9, n = -4;
// void Perebor(int start, int fin)
// {
//     if(start < fin) 
//     {
//         Console.Write(start + " ");
//         start ++;
//     }
//     else if(start > fin)
//     {
//         Console.Write(start + " ");
//         start --;
//     }
//     else {return;}
//     Perebor(start, fin);
// }
// Perebor(m,n);
// Console.Write(n);



// Второй номер

// int num1 = 2, num2 = 2;
// int Ackermann(int m, int n)
// {
//     if(m == 0)
//     {
//         return n + 1;
//     }
//     else if(m > 0 && n == 0)
//     {
//         return Ackermann(m - 1, 1);
//     }
//     else
//     {
//         return Ackermann(m - 1, Ackermann(m, n - 1));
//     }
// }
// Console.Write(Ackermann(num1,num2));



// Третий номер

// Console.WriteLine("Задайте длину массива");
// int len = Convert.ToInt32(Console.ReadLine());
// int[] mas = new int[len];
// void FillMas()
// {
//     for (int i = 0; i < mas.Length; i++)
//     {
//         mas[i] = new Random().Next(0,10);
//         Console.Write(mas[i] + " ");
//     }
// }
// void RetMas(int fin)
// {
//     if(fin == 0)
//     {
//         return;
//     }
//     Console.Write(mas[fin - 1] + " ");
//     RetMas(fin - 1);
// }
// FillMas();
// Console.WriteLine(" ");
// RetMas(len);