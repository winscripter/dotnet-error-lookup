namespace dotnet_error_lookup.Data.Errors;

public class CS0208 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0208";
    string IErrorOrWarning.Message => @"Cannot take the address of, get the size of, or declare a pointer to a managed type ('{0}')";
    string IErrorOrWarning.Explanation => @"[original] Cannot take the address of, get the size of, or declare a pointer to a managed type ('{0}')";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0208";
}
