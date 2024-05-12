namespace dotnet_error_lookup.Data.Errors;

public class CS8190 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8190";
    string IErrorOrWarning.Message => @"Provided source code kind is unsupported or invalid: '{0}'";
    string IErrorOrWarning.Explanation => @"[original] Provided source code kind is unsupported or invalid: '{0}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
