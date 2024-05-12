namespace dotnet_error_lookup.Data.Errors;

public class CS7009 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS7009";
    string IErrorOrWarning.Message => @"Cannot use #r after first token in file";
    string IErrorOrWarning.Explanation => @"[original] Cannot use #r after first token in file";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
