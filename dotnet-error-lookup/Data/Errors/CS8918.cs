namespace dotnet_error_lookup.Data.Errors;

public class CS8918 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8918";
    string IErrorOrWarning.Message => @"Identifier or a simple member access expected.";
    string IErrorOrWarning.Explanation => @"[original] Identifier or a simple member access expected.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
