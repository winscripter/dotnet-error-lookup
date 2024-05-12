namespace dotnet_error_lookup.Data.Errors;

public class CS1011 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1011";
    string IErrorOrWarning.Message => @"Empty character literal";
    string IErrorOrWarning.Explanation => @"[original] Empty character literal";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1011";
}
