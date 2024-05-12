namespace dotnet_error_lookup.Data.Errors;

public class CS8806 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8806";
    string IErrorOrWarning.Message => @"The calling convention of '{0}' is not supported by the language.";
    string IErrorOrWarning.Explanation => @"[original] The calling convention of '{0}' is not supported by the language.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
