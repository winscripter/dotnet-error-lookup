namespace dotnet_error_lookup.Data.Errors;

public class CS1947 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1947";
    string IErrorOrWarning.Message => @"Range variable '{0}' cannot be assigned to -- it is read only";
    string IErrorOrWarning.Explanation => @"[original] Range variable '{0}' cannot be assigned to -- it is read only";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1947";
}
