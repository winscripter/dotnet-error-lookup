namespace dotnet_error_lookup.Data.Errors;

public class CS8081 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8081";
    string IErrorOrWarning.Message => @"Expression does not have a name.";
    string IErrorOrWarning.Explanation => @"[original] Expression does not have a name.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
