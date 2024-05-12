namespace dotnet_error_lookup.Data.Errors;

public class CS8050 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8050";
    string IErrorOrWarning.Message => @"Only auto-implemented properties can have initializers.";
    string IErrorOrWarning.Explanation => @"[original] Only auto-implemented properties can have initializers.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
