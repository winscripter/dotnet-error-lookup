namespace dotnet_error_lookup.Data.Errors;

public class CS0692 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0692";
    string IErrorOrWarning.Message => @"Duplicate type parameter '{0}'";
    string IErrorOrWarning.Explanation => @"[original] Duplicate type parameter '{0}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0692";
}
