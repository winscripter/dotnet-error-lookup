namespace dotnet_error_lookup.Data.Errors;

public class CS8853 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8853";
    string IErrorOrWarning.Message => @"'{0}' must match by init-only of overridden member '{1}'";
    string IErrorOrWarning.Explanation => @"[original] '{0}' must match by init-only of overridden member '{1}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
