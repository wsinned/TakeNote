namespace TakeNote.Cli;

public class Parser {

    public static IEnumerable<string> Parse(string args) {
        return args.Split(" ");
    }
}