namespace dotnet_error_lookup.Data.Errors;

public class CS3028 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Fatal;
    string IErrorOrWarning.Name => @"CS3028";
    string IErrorOrWarning.Message => @"Algorithm '{0}' is not supported";
    string IErrorOrWarning.Explanation => @"[original] Algorithm '{0}' is not supported";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
