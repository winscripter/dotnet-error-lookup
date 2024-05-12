namespace dotnet_error_lookup.Data.Errors;

public class CS1752 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1752";
    string IErrorOrWarning.Message => @"Interop type '{0}' cannot be embedded. Use the applicable interface instead.";
    string IErrorOrWarning.Explanation => @"[original] Interop type '{0}' cannot be embedded. Use the applicable interface instead.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
