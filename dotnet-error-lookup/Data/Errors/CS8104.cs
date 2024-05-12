namespace dotnet_error_lookup.Data.Errors;

public class CS8104 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8104";
    string IErrorOrWarning.Message => @"An error occurred while writing the output file: {0}.";
    string IErrorOrWarning.Explanation => @"[original] An error occurred while writing the output file: {0}.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
