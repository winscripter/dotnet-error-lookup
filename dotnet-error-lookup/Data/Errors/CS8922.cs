namespace dotnet_error_lookup.Data.Errors;

public class CS8922 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8922";
    string IErrorOrWarning.Message => @"The parameter type for ++ or -- operator must be the containing type, or its type parameter constrained to it.";
    string IErrorOrWarning.Explanation => @"[original] The parameter type for ++ or -- operator must be the containing type, or its type parameter constrained to it.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
