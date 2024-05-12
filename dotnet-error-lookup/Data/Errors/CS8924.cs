namespace dotnet_error_lookup.Data.Errors;

public class CS8924 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8924";
    string IErrorOrWarning.Message => @"One of the parameters of a binary operator must be the containing type, or its type parameter constrained to it.";
    string IErrorOrWarning.Explanation => @"[original] One of the parameters of a binary operator must be the containing type, or its type parameter constrained to it.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
