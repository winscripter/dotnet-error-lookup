namespace dotnet_error_lookup.Data.Errors;

public class CS0220 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0220";
    string IErrorOrWarning.Message => @"The operation overflows at compile time in checked mode";
    string IErrorOrWarning.Explanation => @"[original] The operation overflows at compile time in checked mode";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0220";
}
