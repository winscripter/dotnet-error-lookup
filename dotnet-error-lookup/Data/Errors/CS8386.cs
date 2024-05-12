namespace dotnet_error_lookup.Data.Errors;

public class CS8386 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8386";
    string IErrorOrWarning.Message => @"Invalid object creation";
    string IErrorOrWarning.Explanation => @"[original] Invalid object creation";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
