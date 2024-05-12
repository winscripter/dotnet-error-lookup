namespace dotnet_error_lookup.Data.Errors;

public class CS8325 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8325";
    string IErrorOrWarning.Message => @"'await' cannot be used in an expression containing a ref conditional operator";
    string IErrorOrWarning.Explanation => @"[original] 'await' cannot be used in an expression containing a ref conditional operator";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
