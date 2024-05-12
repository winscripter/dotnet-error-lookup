namespace dotnet_error_lookup.Data.Errors;

public class CS0162 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS0162";
    string IErrorOrWarning.Message => @"Unreachable code detected";
    string IErrorOrWarning.Explanation => @"[original] Unreachable code detected";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0162";
}
