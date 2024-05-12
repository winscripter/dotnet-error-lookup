namespace dotnet_error_lookup.Data.Errors;

public class CS9135 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS9135";
    string IErrorOrWarning.Message => @"A constant value of type '{0}' is expected";
    string IErrorOrWarning.Explanation => @"[original] A constant value of type '{0}' is expected";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
