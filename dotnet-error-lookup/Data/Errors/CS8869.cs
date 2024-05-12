namespace dotnet_error_lookup.Data.Errors;

public class CS8869 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8869";
    string IErrorOrWarning.Message => @"'{0}' does not override expected method from 'object'.";
    string IErrorOrWarning.Explanation => @"[original] '{0}' does not override expected method from 'object'.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
