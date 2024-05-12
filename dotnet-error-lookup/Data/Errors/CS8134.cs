namespace dotnet_error_lookup.Data.Errors;

public class CS8134 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8134";
    string IErrorOrWarning.Message => @"Deconstruction must contain at least two variables.";
    string IErrorOrWarning.Explanation => @"[original] Deconstruction must contain at least two variables.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
