namespace dotnet_error_lookup.Data.Errors;

public class CS0128 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0128";
    string IErrorOrWarning.Message => @"A local variable or function named '{0}' is already defined in this scope";
    string IErrorOrWarning.Explanation => @"[original] A local variable or function named '{0}' is already defined in this scope";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0128";
}
