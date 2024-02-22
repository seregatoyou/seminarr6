int a = 13;
int c = 2;
char [,] charArray = new char [a, c];
for(int i = 0; i<c; i++){
    for (int j = 0; j<a; j++){
        Console.WriteLine($"Введите букву требуемого алфавита");
        charArray [j,i] = char.Parse(System.Console.ReadLine());
    }
}
// for(int i = 0; i<c; i++){
//     for (int j = 0; j<a; j++){
//         Console.Write($"{j}{i}");
//         Console.Write($"{charArray[j,i]} \t");
//     }
//     Console.WriteLine();
// }

static string CreateStringFrom2DArray(char[,] array){
string result = "";
for (int i = 0; i < array.GetLength(0); i++)
{
for (int j = 0; j < array.GetLength(1); j++)
{
result+= array[i,j];
}
}
return result;
}

string result = CreateStringFrom2DArray(charArray);
Console.WriteLine($"{result}");