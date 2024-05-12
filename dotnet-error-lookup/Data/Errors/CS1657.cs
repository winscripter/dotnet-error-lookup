namespace dotnet_error_lookup.Data.Errors;

public class CS1657 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1657";
    string IErrorOrWarning.Message => @"Cannot use '{0}' as a ref or out value because it is a '{1}'";
    string IErrorOrWarning.Explanation => @"[original] Cannot use '{0}' as a ref or out value because it is a '{1}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1657";
}
