namespace TakeNote.Tests;

using Xunit;
using TakeNote.Cli;

public class TestParser
{
    [Fact]
    public void ParserReturnsSingleArgument()
    {
        var expected = new List<string>() { "arg1" };
        var sut = TakeNote.Cli.Parser.Parse("arg1");
        Assert.Equal(expected, sut); 
    }

    [Fact]
    public void ParserReturnsTwoArguments()
    {
        var expected = new List<string>() { "arg1", "arg2"};
        var sut = TakeNote.Cli.Parser.Parse("arg1 arg2");
        Assert.Equal(expected, sut);
    }
}
