namespace dotnet_error_lookup.Data.Errors;

public class CS8957 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8957";
    string IErrorOrWarning.Message => @"Conditional expression is not valid in language version {0} because a common type was not found between '{1}' and '{2}'. To use a target-typed conversion, upgrade to language version {3} or greater.";
    string IErrorOrWarning.Explanation => @"[original] Conditional expression is not valid in language version {0} because a common type was not found between '{1}' and '{2}'. To use a target-typed conversion, upgrade to language version {3} or greater.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/feature-version-errors";
}
