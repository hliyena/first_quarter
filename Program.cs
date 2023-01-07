Console.Write("Введите массив данных через запятую: ");
string strLine = Console.ReadLine();
string[] ArrayA = strLine.Split(",");
string[] ArrayB = new string[0];

for (int i = 0; i < ArrayA.Length; i++)
{
    if (ArrayA[i].Length <= 3)
    {
        Array.Resize(ref ArrayB, ArrayB.Length + 1);
        ArrayB[ArrayB.Length-1] = ArrayA[i];
    }
}
Console.WriteLine($"[{string.Join(",", ArrayA)}] => [{string.Join(",", ArrayB)}]");