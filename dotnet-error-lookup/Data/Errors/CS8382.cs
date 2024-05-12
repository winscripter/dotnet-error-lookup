namespace dotnet_error_lookup.Data.Errors;

public class CS8382 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8382";
    string IErrorOrWarning.Message => @"An expression tree may not contain a tuple == or != operator";
    string IErrorOrWarning.Explanation => @"[original] An expression tree may not contain a tuple == or != operator";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
