namespace dotnet_error_lookup.Data.Errors;

public class CS0080 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0080";
    string IErrorOrWarning.Message => @"Constraints are not allowed on non-generic declarations";
    string IErrorOrWarning.Explanation => @"[original] Constraints are not allowed on non-generic declarations";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0080";
}
