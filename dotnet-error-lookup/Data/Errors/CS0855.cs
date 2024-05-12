namespace dotnet_error_lookup.Data.Errors;

public class CS0855 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0855";
    string IErrorOrWarning.Message => @"An expression tree may not contain an indexed property";
    string IErrorOrWarning.Explanation => @"[original] An expression tree may not contain an indexed property";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
