namespace dotnet_error_lookup.Data.Errors;

public class CS7100 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS7100";
    string IErrorOrWarning.Message => @"Assembly culture strings may not contain embedded NUL characters.";
    string IErrorOrWarning.Explanation => @"[original] Assembly culture strings may not contain embedded NUL characters.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
