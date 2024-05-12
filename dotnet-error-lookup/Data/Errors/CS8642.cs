namespace dotnet_error_lookup.Data.Errors;

public class CS8642 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8642";
    string IErrorOrWarning.Message => @"An expression tree may not contain a null coalescing assignment";
    string IErrorOrWarning.Explanation => @"[original] An expression tree may not contain a null coalescing assignment";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
