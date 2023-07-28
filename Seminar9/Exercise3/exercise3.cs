//Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.
Console.Write("Введите переменную M = ");
int M = int.Parse(Console.ReadLine());
Console.Write("Введите переменную N = ");
int N = int.Parse(Console.ReadLine());
Console.WriteLine("Функция равна {SumNumbers(M, N)}");
Console.ReadLine();
static int SumNumbers(int M, int N)
{
    if (M == 0) return (N * (N + 1)) / 2;            
    else if (N == 0) return (M * (M + 1)) / 2;       
    else if (M == N) return M;                       
    else if (M < N) return N + SumNumbers(M, N - 1); 
    else return N + SumNumbers(M, N + 1);            
}
