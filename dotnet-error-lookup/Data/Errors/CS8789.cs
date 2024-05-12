namespace dotnet_error_lookup.Data.Errors;

public class CS8789 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8789";
    string IErrorOrWarning.Message => @"The type of a local declared in a fixed statement cannot be a function pointer type.";
    string IErrorOrWarning.Explanation => @"[original] The type of a local declared in a fixed statement cannot be a function pointer type.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
