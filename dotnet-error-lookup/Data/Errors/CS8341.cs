namespace dotnet_error_lookup.Data.Errors;

public class CS8341 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8341";
    string IErrorOrWarning.Message => @"Auto-implemented instance properties in readonly structs must be readonly.";
    string IErrorOrWarning.Explanation => @"[original] Auto-implemented instance properties in readonly structs must be readonly.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
