namespace dotnet_error_lookup.Data.Errors;

public class CS1743 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1743";
    string IErrorOrWarning.Message => @"Cannot specify a default value for the 'this' parameter";
    string IErrorOrWarning.Explanation => @"[original] Cannot specify a default value for the 'this' parameter";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
