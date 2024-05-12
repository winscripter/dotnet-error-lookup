namespace dotnet_error_lookup.Data.Errors;

public class CS8117 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8117";
    string IErrorOrWarning.Message => @"Invalid operand for pattern match; value required, but found '{0}'.";
    string IErrorOrWarning.Explanation => @"[original] Invalid operand for pattern match; value required, but found '{0}'.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
