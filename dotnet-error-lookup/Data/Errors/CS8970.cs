namespace dotnet_error_lookup.Data.Errors;

public class CS8970 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8970";
    string IErrorOrWarning.Message => @"Type '{0}' cannot be used in this context because it cannot be represented in metadata.";
    string IErrorOrWarning.Explanation => @"[original] Type '{0}' cannot be used in this context because it cannot be represented in metadata.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
