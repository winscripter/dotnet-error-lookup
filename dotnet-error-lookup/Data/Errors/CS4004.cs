namespace dotnet_error_lookup.Data.Errors;

public class CS4004 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS4004";
    string IErrorOrWarning.Message => @"Cannot await in an unsafe context";
    string IErrorOrWarning.Explanation => @"[original] Cannot await in an unsafe context";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs4004";
}
