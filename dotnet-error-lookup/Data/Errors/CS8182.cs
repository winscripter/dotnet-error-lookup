namespace dotnet_error_lookup.Data.Errors;

public class CS8182 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8182";
    string IErrorOrWarning.Message => @"Predefined type '{0}' must be a struct.";
    string IErrorOrWarning.Explanation => @"[original] Predefined type '{0}' must be a struct.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
