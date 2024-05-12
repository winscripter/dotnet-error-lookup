namespace dotnet_error_lookup.Data.Errors;

public class CS8150 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8150";
    string IErrorOrWarning.Message => @"By-value returns may only be used in methods that return by value";
    string IErrorOrWarning.Explanation => @"[original] By-value returns may only be used in methods that return by value";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs8150";
}
