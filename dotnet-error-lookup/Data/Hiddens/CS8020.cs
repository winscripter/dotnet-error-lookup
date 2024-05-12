namespace dotnet_error_lookup.Data.Errors;

public class CS8020 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Hidden;
    string IErrorOrWarning.Name => @"CS8020";
    string IErrorOrWarning.Message => @"Unused extern alias.";
    string IErrorOrWarning.Explanation => @"[original] Unused extern alias.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
