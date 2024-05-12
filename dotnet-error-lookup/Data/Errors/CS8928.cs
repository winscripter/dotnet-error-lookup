namespace dotnet_error_lookup.Data.Errors;

public class CS8928 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8928";
    string IErrorOrWarning.Message => @"'{0}' does not implement static interface member '{1}'. '{2}' cannot implement the interface member because it is not static.";
    string IErrorOrWarning.Explanation => @"[original] '{0}' does not implement static interface member '{1}'. '{2}' cannot implement the interface member because it is not static.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
