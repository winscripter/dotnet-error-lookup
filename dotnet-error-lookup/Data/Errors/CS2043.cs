namespace dotnet_error_lookup.Data.Errors;

public class CS2043 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS2043";
    string IErrorOrWarning.Message => @"'id#' syntax is no longer supported. Use '$id' instead.";
    string IErrorOrWarning.Explanation => @"[original] 'id#' syntax is no longer supported. Use '$id' instead.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
