namespace dotnet_error_lookup.Data.Errors;

public class CS0558 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0558";
    string IErrorOrWarning.Message => @"User-defined operator '{0}' must be declared static and public";
    string IErrorOrWarning.Explanation => @"[original] User-defined operator '{0}' must be declared static and public";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0558";
}
