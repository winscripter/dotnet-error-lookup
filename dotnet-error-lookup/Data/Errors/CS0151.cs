namespace dotnet_error_lookup.Data.Errors;

public class CS0151 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0151";
    string IErrorOrWarning.Message => @"A switch expression or case label must be a bool, char, string, integral, enum, or corresponding nullable type in C# 6 and earlier.";
    string IErrorOrWarning.Explanation => @"[original] A switch expression or case label must be a bool, char, string, integral, enum, or corresponding nullable type in C# 6 and earlier.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs0151";
}
