namespace dotnet_error_lookup.Data.Errors;

public class CS1963 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1963";
    string IErrorOrWarning.Message => @"An expression tree may not contain a dynamic operation";
    string IErrorOrWarning.Explanation => @"[original] An expression tree may not contain a dynamic operation";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
