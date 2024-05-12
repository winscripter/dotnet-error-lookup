namespace dotnet_error_lookup.Data.Errors;

public class CS0747 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0747";
    string IErrorOrWarning.Message => @"Invalid initializer member declarator";
    string IErrorOrWarning.Explanation => @"[original] Invalid initializer member declarator";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0747";
}
