namespace dotnet_error_lookup.Data.Errors;

public class CS8511 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8511";
    string IErrorOrWarning.Message => @"An expression of type '{0}' cannot be handled by a pattern of type '{1}'. Please use language version '{2}' or greater to match an open type with a constant pattern.";
    string IErrorOrWarning.Explanation => @"[original] An expression of type '{0}' cannot be handled by a pattern of type '{1}'. Please use language version '{2}' or greater to match an open type with a constant pattern.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/feature-version-errors";
}
