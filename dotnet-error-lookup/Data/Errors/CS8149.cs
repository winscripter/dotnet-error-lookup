namespace dotnet_error_lookup.Data.Errors;

public class CS8149 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8149";
    string IErrorOrWarning.Message => @"By-reference returns may only be used in methods that return by reference";
    string IErrorOrWarning.Explanation => @"[original] By-reference returns may only be used in methods that return by reference";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs8149";
}
