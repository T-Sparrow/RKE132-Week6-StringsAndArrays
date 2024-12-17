string hello = " we are the champions?";

int stringLenght = hello.Length;

//string trimmedString = hello.Trim();
//Console.WriteLine(stringLenght);
//Console.WriteLine(trimmedString.Length);

//if (hello [i] == ' '){
 //wordCounter++;}

hello = hello.Trim();

char firstLetter = hello[0];
Console.Write(firstLetter);

hello = hello.Replace(hello[0], char.ToUpper(hello[0])).Replace('?', '!');

firstLetter = hello[0];
Console.Write(firstLetter);

Console.WriteLine(hello);


//int wordCounter = 1;
//for(int i = 0; i < hello.Length; i++)
//{
//  if(char.IsWhiteSpace(hello[i]))              
//    {
//        wordCounter++;
//    }                                                                   
//}
//Console.WriteLine($"Word count in {hello}: {wordCounter} words.");