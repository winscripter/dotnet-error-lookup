namespace dotnet_error_lookup.Data.Errors;

public class CS8502 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8502";
    string IErrorOrWarning.Message => @"Matching the tuple type '{0}' requires '{1}' subpatterns, but '{2}' subpatterns are present.";
    string IErrorOrWarning.Explanation => @"[original] Matching the tuple type '{0}' requires '{1}' subpatterns, but '{2}' subpatterns are present.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
