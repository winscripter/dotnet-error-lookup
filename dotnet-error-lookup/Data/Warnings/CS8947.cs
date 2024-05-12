namespace dotnet_error_lookup.Data.Errors;

public class CS8947 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS8947";
    string IErrorOrWarning.Message => @"Parameter '{0}' occurs after '{1}' in the parameter list, but is used as an argument for interpolated string handler conversions. This will require the caller to reorder parameters with named arguments at the call site. Consider putting the interpolated string handler parameter after all arguments involved.";
    string IErrorOrWarning.Explanation => @"[original] Parameter '{0}' occurs after '{1}' in the parameter list, but is used as an argument for interpolated string handler conversions. This will require the caller to reorder parameters with named arguments at the call site. Consider putting the interpolated string handler parameter after all arguments involved.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
