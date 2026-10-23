using System.Runtime.InteropServices.Marshalling;
using System.Text;
Console.OutputEncoding = Encoding.UTF8;
Console.InputEncoding = Encoding.UTF8;
Console.WriteLine("FunWithMethods!");
//// приклад 1
//static int Add(int x, int y)
//{
//    int ans = x + y;
//    // Вызывающий код не увидит эти изменения,
//    // т.к. модифицируется копия исходных данных,
//    x = 10000;
//    y = 88888;
//    return ans;
//}

//int x = 9, y = 10;
//Console.WriteLine("Before call: X: {0}, Y: {1}", x, y);
//// Значения перед вызовом
//Console.WriteLine("Answer is: {0}", Add(x, y));
//// Результат сложения
//Console.WriteLine("After call: X: {0}, Y: {1}", x, y);
//// Значения после вызова
//Console.ReadLine();

// приклад 2

//static void AddUsingOutParam(int x, int y, out int ans)
//{
//    ans = x + y;
//}
//Console.WriteLine("Fun with Methods!");
//// Присваивать начальные значения локальным переменным, используемым
//// как выходные параметры, не обязательно при условии, что они
//// применяются в таком качестве впервые.
//// Версия C# 7 позволяет объявлять параметры out в вызове метода.
//AddUsingOutParam(90, 90, out int ans);
//Console.WriteLine("90 + 90 = {0}", ans);
//Console.ReadLine();

static void FillTheseValues(out int a, out string b, out bool c)
{
    a = 9;
    b = "Enjoy your string.";
    c = true;
}
FillTheseValues(out int i, out string str, out bool b);
Console.WriteLine("Int is: {0}", i); // Вывод целочисленного значения
Console.WriteLine("String is: {0}", str); // Вывод строкового значения
Console.WriteLine("Boolean is: {0}", b); // Вывод булевского значения
Console.ReadLine();