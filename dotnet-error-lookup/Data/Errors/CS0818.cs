namespace dotnet_error_lookup.Data.Errors;

public class CS0818 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0818";
    string IErrorOrWarning.Message => @"Implicitly-typed variables must be initialized";
    string IErrorOrWarning.Explanation => @"[original] Implicitly-typed variables must be initialized";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0818";
}
