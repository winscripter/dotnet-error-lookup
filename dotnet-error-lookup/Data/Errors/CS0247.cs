namespace dotnet_error_lookup.Data.Errors;

public class CS0247 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0247";
    string IErrorOrWarning.Message => @"Cannot use a negative size with stackalloc";
    string IErrorOrWarning.Explanation => @"[original] Cannot use a negative size with stackalloc";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0247";
}
