namespace dotnet_error_lookup.Data.Errors;

public class CS8968 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8968";
    string IErrorOrWarning.Message => @"'{0}': an attribute type argument cannot use type parameters";
    string IErrorOrWarning.Explanation => @"[original] '{0}': an attribute type argument cannot use type parameters";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
