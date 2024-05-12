namespace dotnet_error_lookup.Data.Errors;

public class CS0026 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0026";
    string IErrorOrWarning.Message => @"Keyword 'this' is not valid in a static property, static method, or static field initializer";
    string IErrorOrWarning.Explanation => @"[original] Keyword 'this' is not valid in a static property, static method, or static field initializer";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0026";
}
