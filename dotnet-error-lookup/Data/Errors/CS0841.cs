namespace dotnet_error_lookup.Data.Errors;

public class CS0841 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0841";
    string IErrorOrWarning.Message => @"Cannot use local variable '{0}' before it is declared";
    string IErrorOrWarning.Explanation => @"[original] Cannot use local variable '{0}' before it is declared";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0841";
}
