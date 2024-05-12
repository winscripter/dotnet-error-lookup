namespace dotnet_error_lookup.Data.Errors;

public class CS8903 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8903";
    string IErrorOrWarning.Message => @"'init' accessors cannot be marked 'readonly'. Mark '{0}' readonly instead.";
    string IErrorOrWarning.Explanation => @"[original] 'init' accessors cannot be marked 'readonly'. Mark '{0}' readonly instead.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
