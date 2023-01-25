// Принимает на вход координаты двух точек и находит 
//расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Введите координаты первого числа (x1, y1, z1): ");
string[] i = Console.ReadLine().Split();

int x1 = int.Parse(i[0]);
int y1 = int.Parse(i[1]);
int z1 = int.Parse(i[2]);

Console.Write("Введите координаты второго числа (x2, y2, z2): ");
string[] I = Console.ReadLine().Split() ;

int x2 = int.Parse(I[0]);
int y2 = int.Parse(I[1]);
int z2 = int.Parse(I[2]);

double result = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));

System.Console.WriteLine($"A ({x1}, {y1}, {z1}); B ({x2}, {y2}, {z2}) -> {result}");

 