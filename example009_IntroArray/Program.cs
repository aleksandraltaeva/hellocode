// int Max(int arg1, int arg2, int arg3)
// {
//     int result = arg1;
//     if (arg2 > result) result = arg2;
//     if (arg3 > result) result = arg3;
//     return result;
// }

int[] array = { 1, 32, 345, 41, 35, 76, 90, 843, 90 };

int n = array.Length;
int find = 90;

int index = 0;

while (index < n)
{
    if (array[index] == find) { Console.WriteLine(index); }
    index++;
}
