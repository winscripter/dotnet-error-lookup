namespace dotnet_error_lookup.Data.Errors;

public class CS8998 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8998";
    string IErrorOrWarning.Message => @"The raw string literal does not start with enough quote characters to allow this many consecutive quote characters as content.";
    string IErrorOrWarning.Explanation => @"[original] The raw string literal does not start with enough quote characters to allow this many consecutive quote characters as content.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
