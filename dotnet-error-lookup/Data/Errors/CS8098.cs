namespace dotnet_error_lookup.Data.Errors;

public class CS8098 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8098";
    string IErrorOrWarning.Message => @"Cannot use #load after first token in file";
    string IErrorOrWarning.Explanation => @"[original] Cannot use #load after first token in file";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
