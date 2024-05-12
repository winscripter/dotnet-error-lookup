namespace dotnet_error_lookup.Data.Errors;

public class CS8655 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS8655";
    string IErrorOrWarning.Message => @"The switch expression does not handle some null inputs (it is not exhaustive). For example, the pattern '{0}' is not covered.";
    string IErrorOrWarning.Explanation => @"[original] The switch expression does not handle some null inputs (it is not exhaustive). For example, the pattern '{0}' is not covered.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/nullable-warnings";
}
