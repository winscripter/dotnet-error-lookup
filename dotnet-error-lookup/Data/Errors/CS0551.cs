namespace dotnet_error_lookup.Data.Errors;

public class CS0551 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0551";
    string IErrorOrWarning.Message => @"Explicit interface implementation '{0}' is missing accessor '{1}'";
    string IErrorOrWarning.Explanation => @"[original] Explicit interface implementation '{0}' is missing accessor '{1}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0551";
}
