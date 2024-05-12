namespace dotnet_error_lookup.Data.Errors;

public class CS8712 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8712";
    string IErrorOrWarning.Message => @"'{0}': abstract event cannot use event accessor syntax";
    string IErrorOrWarning.Explanation => @"[original] '{0}': abstract event cannot use event accessor syntax";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
