namespace dotnet_error_lookup.Data.Errors;

public class CS7090 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS7090";
    string IErrorOrWarning.Message => @"Attribute '{0}' from module '{1}' will be ignored in favor of the instance appearing in source";
    string IErrorOrWarning.Explanation => @"[original] Attribute '{0}' from module '{1}' will be ignored in favor of the instance appearing in source";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
