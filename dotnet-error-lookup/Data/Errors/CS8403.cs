namespace dotnet_error_lookup.Data.Errors;

public class CS8403 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8403";
    string IErrorOrWarning.Message => @"Method '{0}' with an iterator block must be 'async' to return '{1}'";
    string IErrorOrWarning.Explanation => @"[original] Method '{0}' with an iterator block must be 'async' to return '{1}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs8403";
}
