namespace dotnet_error_lookup.Data.Errors;

public class CS7093 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS7093";
    string IErrorOrWarning.Message => @"Cannot read config file '{0}' -- '{1}'";
    string IErrorOrWarning.Explanation => @"[original] Cannot read config file '{0}' -- '{1}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
