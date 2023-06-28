namespace FirstUnique;

public class UniqueFinder
{
    public static char Find(string text)
    {
        var words = text.Split();

        var wordsCharArrays = words.Select(w => w.ToCharArray());

        var distinct = wordsCharArrays.Select(FindFirstUnique);

        return FindFirstUnique(distinct.ToArray());
    }
    
    private static char FindFirstUnique(char[] chars)
    {
        return chars.GroupBy(x => x)
            .Where(g => g.Count() == 1)
            .Select(g => g.Key)
            .FirstOrDefault();            
    }
}