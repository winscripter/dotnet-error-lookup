namespace dotnet_error_lookup.Data.Errors;

public class CS7065 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS7065";
    string IErrorOrWarning.Message => @"Error building Win32 resources -- {0}";
    string IErrorOrWarning.Explanation => @"[original] Error building Win32 resources -- {0}";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
