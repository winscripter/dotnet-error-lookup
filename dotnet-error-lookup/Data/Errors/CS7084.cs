namespace dotnet_error_lookup.Data.Errors;

public class CS7084 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS7084";
    string IErrorOrWarning.Message => @"A Windows Runtime event may not be passed as an out or ref parameter.";
    string IErrorOrWarning.Explanation => @"[original] A Windows Runtime event may not be passed as an out or ref parameter.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
