namespace dotnet_error_lookup.Data.Errors;

public class CS8110 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8110";
    string IErrorOrWarning.Message => @"An expression tree may not contain a reference to a local function";
    string IErrorOrWarning.Explanation => @"[original] An expression tree may not contain a reference to a local function";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
