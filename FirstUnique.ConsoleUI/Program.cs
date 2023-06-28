namespace FirstUnique.Console;

class Program
{
    public static void Main()
    {
        System.Console.WriteLine("Enter path to your text: ");
        var filePath = System.Console.ReadLine();
        while(string.IsNullOrEmpty(filePath))
        {
            System.Console.WriteLine("You have entered empty string. Try again: ");
        }

        var text = string.Empty;

        try
        {
            using var fileReader = new StreamReader(filePath);
            text = fileReader.ReadToEnd();
        }
        catch(IOException)
        {
            System.Console.WriteLine("Wrong path!");
        }
            
        if(string.IsNullOrEmpty(text))
        {
            System.Console.WriteLine("Text in the file is empty. Nothing to find.");
            return;
        }
        
        var unique =  UniqueFinder.Find(text);
        System.Console.WriteLine(unique != default(char)
            ? $"First unique char in this sequence is: {unique}"
            : "No unique values were found!");
    }
}