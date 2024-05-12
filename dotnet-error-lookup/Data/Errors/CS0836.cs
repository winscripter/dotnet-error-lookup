namespace dotnet_error_lookup.Data.Errors;

public class CS0836 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0836";
    string IErrorOrWarning.Message => @"Cannot use anonymous type in a constant expression";
    string IErrorOrWarning.Explanation => @"[original] Cannot use anonymous type in a constant expression";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0836";
}
