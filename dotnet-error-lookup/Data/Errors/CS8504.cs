namespace dotnet_error_lookup.Data.Errors;

public class CS8504 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8504";
    string IErrorOrWarning.Message => @"Pattern missing";
    string IErrorOrWarning.Explanation => @"[original] Pattern missing";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
