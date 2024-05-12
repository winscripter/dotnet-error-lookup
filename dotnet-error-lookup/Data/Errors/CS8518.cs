namespace dotnet_error_lookup.Data.Errors;

public class CS8518 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8518";
    string IErrorOrWarning.Message => @"An expression of type '{0}' can never match the provided pattern.";
    string IErrorOrWarning.Explanation => @"[original] An expression of type '{0}' can never match the provided pattern.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
