namespace dotnet_error_lookup.Data.Errors;

public class CS8196 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8196";
    string IErrorOrWarning.Message => @"Reference to an implicitly-typed out variable '{0}' is not permitted in the same argument list.";
    string IErrorOrWarning.Explanation => @"[original] Reference to an implicitly-typed out variable '{0}' is not permitted in the same argument list.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
