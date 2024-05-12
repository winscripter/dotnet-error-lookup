namespace dotnet_error_lookup.Data.Errors;

public class CS9046 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS9046";
    string IErrorOrWarning.Message => @"One of the parameters of an equality, or inequality operator declared in interface '{0}' must be a type parameter on '{0}' constrained to '{0}'";
    string IErrorOrWarning.Explanation => @"[original] One of the parameters of an equality, or inequality operator declared in interface '{0}' must be a type parameter on '{0}' constrained to '{0}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
