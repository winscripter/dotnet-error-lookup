namespace dotnet_error_lookup.Data.Errors;

public class CS8019 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Hidden;
    string IErrorOrWarning.Name => @"CS8019";
    string IErrorOrWarning.Message => @"Unnecessary using directive.";
    string IErrorOrWarning.Explanation => @"[original] Unnecessary using directive.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
