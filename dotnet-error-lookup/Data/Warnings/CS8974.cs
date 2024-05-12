namespace dotnet_error_lookup.Data.Errors;

public class CS8974 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS8974";
    string IErrorOrWarning.Message => @"Converting method group '{0}' to non-delegate type '{1}'. Did you intend to invoke the method?";
    string IErrorOrWarning.Explanation => @"[original] Converting method group '{0}' to non-delegate type '{1}'. Did you intend to invoke the method?";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
