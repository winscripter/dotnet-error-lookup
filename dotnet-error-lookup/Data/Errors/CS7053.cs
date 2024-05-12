namespace dotnet_error_lookup.Data.Errors;

public class CS7053 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS7053";
    string IErrorOrWarning.Message => @"An expression tree may not contain '{0}'";
    string IErrorOrWarning.Explanation => @"[original] An expression tree may not contain '{0}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
