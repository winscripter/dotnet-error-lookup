namespace dotnet_error_lookup.Data.Errors;

public class CS7064 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS7064";
    string IErrorOrWarning.Message => @"Error opening icon file {0} -- {1}";
    string IErrorOrWarning.Explanation => @"[original] Error opening icon file {0} -- {1}";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
