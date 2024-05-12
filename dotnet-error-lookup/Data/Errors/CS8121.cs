namespace dotnet_error_lookup.Data.Errors;

public class CS8121 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8121";
    string IErrorOrWarning.Message => @"An expression of type '{0}' cannot be handled by a pattern of type '{1}'.";
    string IErrorOrWarning.Explanation => @"[original] An expression of type '{0}' cannot be handled by a pattern of type '{1}'.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
