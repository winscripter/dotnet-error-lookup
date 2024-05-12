namespace dotnet_error_lookup.Data.Errors;

public class CS1625 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1625";
    string IErrorOrWarning.Message => @"Cannot yield in the body of a finally clause";
    string IErrorOrWarning.Explanation => @"[original] Cannot yield in the body of a finally clause";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1625";
}
