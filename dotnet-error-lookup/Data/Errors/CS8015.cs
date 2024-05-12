namespace dotnet_error_lookup.Data.Errors;

public class CS8015 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8015";
    string IErrorOrWarning.Message => @"Module '{0}' is already defined in this assembly. Each module must have a unique filename.";
    string IErrorOrWarning.Explanation => @"[original] Module '{0}' is already defined in this assembly. Each module must have a unique filename.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
