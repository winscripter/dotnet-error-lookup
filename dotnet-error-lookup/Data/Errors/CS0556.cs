namespace dotnet_error_lookup.Data.Errors;

public class CS0556 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0556";
    string IErrorOrWarning.Message => @"User-defined conversion must convert to or from the enclosing type";
    string IErrorOrWarning.Explanation => @"[original] User-defined conversion must convert to or from the enclosing type";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0556";
}
