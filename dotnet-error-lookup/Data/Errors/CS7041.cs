namespace dotnet_error_lookup.Data.Errors;

public class CS7041 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS7041";
    string IErrorOrWarning.Message => @"Each linked resource and module must have a unique filename. Filename '{0}' is specified more than once in this assembly";
    string IErrorOrWarning.Explanation => @"[original] Each linked resource and module must have a unique filename. Filename '{0}' is specified more than once in this assembly";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
