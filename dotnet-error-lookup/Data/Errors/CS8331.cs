namespace dotnet_error_lookup.Data.Errors;

public class CS8331 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8331";
    string IErrorOrWarning.Message => @"Cannot assign to {0} '{1}' or use it as the right hand side of a ref assignment because it is a readonly variable";
    string IErrorOrWarning.Explanation => @"[original] Cannot assign to {0} '{1}' or use it as the right hand side of a ref assignment because it is a readonly variable";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
