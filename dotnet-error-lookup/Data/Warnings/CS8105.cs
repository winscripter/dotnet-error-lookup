namespace dotnet_error_lookup.Data.Errors;

public class CS8105 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS8105";
    string IErrorOrWarning.Message => @"Attribute '{0}' is ignored when public signing is specified.";
    string IErrorOrWarning.Explanation => @"[original] Attribute '{0}' is ignored when public signing is specified.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
