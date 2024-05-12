namespace dotnet_error_lookup.Data.Errors;

public class CS9093 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS9093";
    string IErrorOrWarning.Message => @"This ref-assigns '{1}' to '{0}' but '{1}' can only escape the current method through a return statement.";
    string IErrorOrWarning.Explanation => @"[original] This ref-assigns '{1}' to '{0}' but '{1}' can only escape the current method through a return statement.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
