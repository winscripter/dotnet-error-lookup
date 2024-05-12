namespace dotnet_error_lookup.Data.Errors;

public class CS7098 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS7098";
    string IErrorOrWarning.Message => @"Linked netmodule metadata must provide a full PE image: '{0}'.";
    string IErrorOrWarning.Explanation => @"[original] Linked netmodule metadata must provide a full PE image: '{0}'.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
