namespace dotnet_error_lookup.Data.Errors;

public class CS8153 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8153";
    string IErrorOrWarning.Message => @"An expression tree lambda may not contain a call to a method, property, or indexer that returns by reference";
    string IErrorOrWarning.Explanation => @"[original] An expression tree lambda may not contain a call to a method, property, or indexer that returns by reference";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs8153";
}
