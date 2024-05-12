using dotnet_error_lookup.Data;

if (args.Length == 0)
{
    Console.WriteLine("Expected 1 command-line argument: the compiler error (or warning) name.");
}

var lookup = new ErrorLookupHandler();
Console.WriteLine("Searching for the given error...");
var matchingItem = lookup.LookUp(args[0]);

if (matchingItem is null)
{
    Console.WriteLine("Sorry!");
    Console.WriteLine();
    Console.WriteLine($"We could not find any description about the syntax error or warning '{args[0]}'.");
    Console.WriteLine("If you believe that this C# syntax error exists, you can create an issue post on the GitHub:");
    Console.WriteLine("    https://github.com/winscripter/dotnet-error-lookup");
}
else
{
    string url = matchingItem.DocumentationReference;
    string type = matchingItem.ErrorType.ToString();
    string message = matchingItem.Message;
    string sample = matchingItem.SampleCode;
    string fix = matchingItem.SampleFix;

    Console.WriteLine($"We found a syntax diagnostic '{args[0]}.'{Environment.NewLine}{Environment.NewLine}");

    Console.WriteLine($"Type: {type}");
    Console.WriteLine($"Message: \"{message}\"");

    if (url != string.Empty) Console.WriteLine($"Documentation Reference: {url}");
    else Console.WriteLine("Documentation Reference: it doesn't look like it is documented");

    if (sample != string.Empty) Console.WriteLine($"Sample Code:{Environment.NewLine}{sample}");
    else Console.WriteLine("No sample code for this error.");

    if (fix != string.Empty) Console.WriteLine($"Sample Fix:{Environment.NewLine}{sample}");
    else Console.WriteLine("No sample fix documented for this error.");
}
