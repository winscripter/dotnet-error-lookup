namespace dotnet_error_lookup.Data.Errors;

public class CS9052 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS9052";
    string IErrorOrWarning.Message => @"File-local type '{0}' cannot use accessibility modifiers.";
    string IErrorOrWarning.Explanation => @"[original] File-local type '{0}' cannot use accessibility modifiers.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
