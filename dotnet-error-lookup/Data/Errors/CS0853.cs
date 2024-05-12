namespace dotnet_error_lookup.Data.Errors;

public class CS0853 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0853";
    string IErrorOrWarning.Message => @"An expression tree may not contain a named argument specification";
    string IErrorOrWarning.Explanation => @"[original] An expression tree may not contain a named argument specification";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
