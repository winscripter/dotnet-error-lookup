namespace dotnet_error_lookup.Data.Errors;

public class CS8148 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8148";
    string IErrorOrWarning.Message => @"'{0}' must match by reference return of overridden member '{1}'";
    string IErrorOrWarning.Explanation => @"[original] '{0}' must match by reference return of overridden member '{1}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs8148";
}
