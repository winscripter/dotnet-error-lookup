namespace dotnet_error_lookup.Data.Errors;

public class CS8186 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8186";
    string IErrorOrWarning.Message => @"A foreach loop must declare its iteration variables.";
    string IErrorOrWarning.Explanation => @"[original] A foreach loop must declare its iteration variables.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
