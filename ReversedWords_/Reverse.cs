namespace ReversedWords_;

public class Reverse
{
    public void Rvrs()
    {
        string sentence, reversed="";
        
        Console.Write("Enter the words to be reversed: ");
        sentence = Console.ReadLine();
        
        string[] words = sentence.Split(" ");

        for (int i = 0; i <= words.Length - 1; i++)
        {
            words[i] = words[i].Substring(1, words[i].Length - 1) + words[i][0] ;
            reversed += words[i] + " ";
        }
        
        Console.WriteLine(reversed);
    }
}