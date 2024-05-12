namespace dotnet_error_lookup.Data.Errors;

public class CS0822 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0822";
    string IErrorOrWarning.Message => @"Implicitly-typed variables cannot be constant";
    string IErrorOrWarning.Explanation => @"[original] Implicitly-typed variables cannot be constant";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0822";
}
