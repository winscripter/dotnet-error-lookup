namespace dotnet_error_lookup.Data.Errors;

public class CS4028 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS4028";
    string IErrorOrWarning.Message => @"'await' requires that the type '{0}' have a suitable 'GetAwaiter' method. Are you missing a using directive for 'System'?";
    string IErrorOrWarning.Explanation => @"[original] 'await' requires that the type '{0}' have a suitable 'GetAwaiter' method. Are you missing a using directive for 'System'?";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
