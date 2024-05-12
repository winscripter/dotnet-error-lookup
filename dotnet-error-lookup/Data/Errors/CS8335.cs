namespace dotnet_error_lookup.Data.Errors;

public class CS8335 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8335";
    string IErrorOrWarning.Message => @"Do not use '{0}'. This is reserved for compiler usage.";
    string IErrorOrWarning.Explanation => @"[original] Do not use '{0}'. This is reserved for compiler usage.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
