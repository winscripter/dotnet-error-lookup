namespace dotnet_error_lookup.Data.Errors;

public class CS8207 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8207";
    string IErrorOrWarning.Message => @"An expression tree may not contain a discard.";
    string IErrorOrWarning.Explanation => @"[original] An expression tree may not contain a discard.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
