namespace dotnet_error_lookup.Data.Errors;

public class CS8915 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8915";
    string IErrorOrWarning.Message => @"A global using directive must precede all non-global using directives.";
    string IErrorOrWarning.Explanation => @"[original] A global using directive must precede all non-global using directives.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
