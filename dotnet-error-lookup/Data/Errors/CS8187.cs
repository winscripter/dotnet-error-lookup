namespace dotnet_error_lookup.Data.Errors;

public class CS8187 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8187";
    string IErrorOrWarning.Message => @"Tuple element names are not permitted on the left of a deconstruction.";
    string IErrorOrWarning.Explanation => @"[original] Tuple element names are not permitted on the left of a deconstruction.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
