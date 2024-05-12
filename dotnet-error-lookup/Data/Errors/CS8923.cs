namespace dotnet_error_lookup.Data.Errors;

public class CS8923 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8923";
    string IErrorOrWarning.Message => @"The return type for ++ or -- operator must either match the parameter type, or be derived from the parameter type, or be the containing type's type parameter constrained to it unless the parameter type is a different type parameter.";
    string IErrorOrWarning.Explanation => @"[original] The return type for ++ or -- operator must either match the parameter type, or be derived from the parameter type, or be the containing type's type parameter constrained to it unless the parameter type is a different type parameter.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
