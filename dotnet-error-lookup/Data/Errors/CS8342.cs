namespace dotnet_error_lookup.Data.Errors;

public class CS8342 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8342";
    string IErrorOrWarning.Message => @"Field-like events are not allowed in readonly structs.";
    string IErrorOrWarning.Explanation => @"[original] Field-like events are not allowed in readonly structs.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
