namespace dotnet_error_lookup.Data.Errors;

public class CS8094 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS8094";
    string IErrorOrWarning.Message => @"Alignment value {0} has a magnitude greater than {1} and may result in a large formatted string.";
    string IErrorOrWarning.Explanation => @"[original] Alignment value {0} has a magnitude greater than {1} and may result in a large formatted string.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
