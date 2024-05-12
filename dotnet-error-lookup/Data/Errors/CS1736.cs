namespace dotnet_error_lookup.Data.Errors;

public class CS1736 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1736";
    string IErrorOrWarning.Message => @"Default parameter value for '{0}' must be a compile-time constant";
    string IErrorOrWarning.Explanation => @"[original] Default parameter value for '{0}' must be a compile-time constant";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs1736";
}
