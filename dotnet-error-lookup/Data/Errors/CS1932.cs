namespace dotnet_error_lookup.Data.Errors;

public class CS1932 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1932";
    string IErrorOrWarning.Message => @"Cannot assign {0} to a range variable";
    string IErrorOrWarning.Explanation => @"[original] Cannot assign {0} to a range variable";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1932";
}
