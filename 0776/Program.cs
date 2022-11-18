Console.Write("Введите количество шишек: ");
int n = int.Parse(Console.ReadLine());

Console.Write("Введите количество орешков в шишках: ");
int m = int.Parse(Console.ReadLine());

Console.Write("Введите запас орешков на зиму: ");
int k = int.Parse(Console.ReadLine());

if ((n < 0) || (m < 0 && m > 100) || (k < 0 && k > 10000)) Console.WriteLine("Шишек должно быть не меньше 0\nОрешков не меньше 0 и не более 100 \nЗапас не более 10000");

else if (n * m >= k) Console.WriteLine("YES");

else System.Console.WriteLine("NO");

