namespace dotnet_error_lookup.Data.Errors;

public class CS0405 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0405";
    string IErrorOrWarning.Message => @"Duplicate constraint '{0}' for type parameter '{1}'";
    string IErrorOrWarning.Explanation => @"[original] Duplicate constraint '{0}' for type parameter '{1}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0405";
}
