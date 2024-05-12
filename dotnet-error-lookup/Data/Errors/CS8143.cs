namespace dotnet_error_lookup.Data.Errors;

public class CS8143 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8143";
    string IErrorOrWarning.Message => @"An expression tree may not contain a tuple literal.";
    string IErrorOrWarning.Explanation => @"[original] An expression tree may not contain a tuple literal.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
