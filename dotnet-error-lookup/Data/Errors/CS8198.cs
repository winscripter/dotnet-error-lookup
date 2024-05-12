namespace dotnet_error_lookup.Data.Errors;

public class CS8198 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8198";
    string IErrorOrWarning.Message => @"An expression tree may not contain an out argument variable declaration.";
    string IErrorOrWarning.Explanation => @"[original] An expression tree may not contain an out argument variable declaration.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
