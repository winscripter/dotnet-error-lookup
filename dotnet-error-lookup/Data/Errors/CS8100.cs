namespace dotnet_error_lookup.Data.Errors;

public class CS8100 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8100";
    string IErrorOrWarning.Message => @"The 'await' operator cannot be used in a static script variable initializer.";
    string IErrorOrWarning.Explanation => @"[original] The 'await' operator cannot be used in a static script variable initializer.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
