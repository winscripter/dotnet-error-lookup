namespace dotnet_error_lookup.Data.Errors;

public class CS8321 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS8321";
    string IErrorOrWarning.Message => @"The local function '{0}' is declared but never used";
    string IErrorOrWarning.Explanation => @"[original] The local function '{0}' is declared but never used";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
