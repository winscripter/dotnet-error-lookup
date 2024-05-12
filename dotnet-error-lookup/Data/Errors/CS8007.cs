namespace dotnet_error_lookup.Data.Errors;

public class CS8007 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8007";
    string IErrorOrWarning.Message => @"Type '{0}' forwarded to assembly '{1}' conflicts with type '{2}' forwarded to assembly '{3}'.";
    string IErrorOrWarning.Explanation => @"[original] Type '{0}' forwarded to assembly '{1}' conflicts with type '{2}' forwarded to assembly '{3}'.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
