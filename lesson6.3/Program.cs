string input = "adadaa";
char[] revText = input.ToCharArray();
Array.Reverse(revText);
string finalText = new string(revText);

if(input == finalText){
    Console.WriteLine("Да, палиндром.");
}
else{
    Console.WriteLine("Нет, не палиндром.");
}