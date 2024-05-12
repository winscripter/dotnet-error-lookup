namespace dotnet_error_lookup.Data.Errors;

public class CS1072 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS1072";
    string IErrorOrWarning.Message => @"Expected identifier or numeric literal.";
    string IErrorOrWarning.Explanation => @"[original] Expected identifier or numeric literal.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
