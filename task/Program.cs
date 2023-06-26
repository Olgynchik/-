// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив
// из строк, длина которых меньше, либо равна 3 символам.


string[] massiv1 = new string [6] {"dog", "RU", "0", "357951", "33", "+"};
string[] massiv2 = new string[massiv1.Length];
void newMassiv (string[] massiv1, string[] massiv2)
{
    int count = 0;
    for (int i = 0; i < massiv1.Length; i++)
    {
    if(massiv1[i].Length <= 3)
        {
        massiv2[count] = massiv1[i];
        count++;
        }
    }
}
void Print (string[] Array)
{
    for (int i = 0; i < Array.Length; i++)
    {
        System.Console.Write($"{Array[i]}" +" ");

    } 
    System.Console.WriteLine();
}
newMassiv (massiv1, massiv2);
Print (massiv2);
