namespace dotnet_error_lookup.Data.Errors;

public class CS8858 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8858";
    string IErrorOrWarning.Message => @"The receiver type '{0}' is not a valid record type and is not a struct type.";
    string IErrorOrWarning.Explanation => @"[original] The receiver type '{0}' is not a valid record type and is not a struct type.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
