namespace dotnet_error_lookup.Data.Errors;

public class CS0263 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0263";
    string IErrorOrWarning.Message => @"Partial declarations of '{0}' must not specify different base classes";
    string IErrorOrWarning.Explanation => @"[original] Partial declarations of '{0}' must not specify different base classes";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0263";
}
