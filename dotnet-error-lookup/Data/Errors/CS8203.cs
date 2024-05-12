namespace dotnet_error_lookup.Data.Errors;

public class CS8203 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8203";
    string IErrorOrWarning.Message => @"Invalid assembly name: {0}";
    string IErrorOrWarning.Explanation => @"[original] Invalid assembly name: {0}";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
