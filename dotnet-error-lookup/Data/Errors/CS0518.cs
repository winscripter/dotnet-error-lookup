namespace dotnet_error_lookup.Data.Errors;

public class CS0518 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0518";
    string IErrorOrWarning.Message => @"Predefined type '{0}' is not defined or imported";
    string IErrorOrWarning.Explanation => @"[original] Predefined type '{0}' is not defined or imported";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs0518";
}
