namespace dotnet_error_lookup.Data.Errors;

public class CS0819 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0819";
    string IErrorOrWarning.Message => @"Implicitly-typed variables cannot have multiple declarators";
    string IErrorOrWarning.Explanation => @"[original] Implicitly-typed variables cannot have multiple declarators";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0819";
}
