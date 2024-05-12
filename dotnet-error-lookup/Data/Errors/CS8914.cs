namespace dotnet_error_lookup.Data.Errors;

public class CS8914 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8914";
    string IErrorOrWarning.Message => @"A global using directive cannot be used in a namespace declaration.";
    string IErrorOrWarning.Explanation => @"[original] A global using directive cannot be used in a namespace declaration.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
