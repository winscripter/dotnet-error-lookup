namespace dotnet_error_lookup.Data.Errors;

public class CS1604 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1604";
    string IErrorOrWarning.Message => @"Cannot assign to '{0}' because it is read-only";
    string IErrorOrWarning.Explanation => @"[original] Cannot assign to '{0}' because it is read-only";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1604";
}
