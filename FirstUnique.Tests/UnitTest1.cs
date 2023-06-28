using FirstUnique;

namespace TestProject1;

public class UniqueFinderTests
{
    [Theory]
    [InlineData("apple", 'a')]
    [InlineData("banana", 'b')]
    [InlineData("racecar", 'e')]
    [InlineData("tTt", 'T')]
    [InlineData("tTt This Equality", 'E')]
    [InlineData("bb CC", 0)]
    [InlineData("", 0)]
    [InlineData(" ", 0)]
    [InlineData(@"The Tao gave birth to machine language.  Machine language gave birth
    to the assembler.
        The assembler gave birth to the compiler.  Now there are ten thousand
        languages.
        Each language has its purpose, however humble.  Each language
    expresses the Yin and Yang of software.  Each language has its place within
    the Tao.
        But do not program in COBOL if you can avoid it.
    -- Geoffrey James, The Tao of Programming", 'm')]
    
    public void FindUniqueReturnCorrectChars(string text, char expected)
    {
        Assert.Equal(UniqueFinder.Find(text), expected);
    }
}