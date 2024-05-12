namespace dotnet_error_lookup.Data.Errors;

public class CS1626 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1626";
    string IErrorOrWarning.Message => @"Cannot yield a value in the body of a try block with a catch clause";
    string IErrorOrWarning.Explanation => @"[original] Cannot yield a value in the body of a try block with a catch clause";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1626";
}
