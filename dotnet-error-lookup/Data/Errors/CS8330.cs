namespace dotnet_error_lookup.Data.Errors;

public class CS8330 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8330";
    string IErrorOrWarning.Message => @"Members of {0} '{1}' cannot be used as a ref or out value because it is a readonly variable";
    string IErrorOrWarning.Explanation => @"[original] Members of {0} '{1}' cannot be used as a ref or out value because it is a readonly variable";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
