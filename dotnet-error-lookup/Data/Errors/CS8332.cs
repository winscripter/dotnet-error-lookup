namespace dotnet_error_lookup.Data.Errors;

public class CS8332 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8332";
    string IErrorOrWarning.Message => @"Cannot assign to a member of {0} '{1}' or use it as the right hand side of a ref assignment because it is a readonly variable";
    string IErrorOrWarning.Explanation => @"[original] Cannot assign to a member of {0} '{1}' or use it as the right hand side of a ref assignment because it is a readonly variable";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
