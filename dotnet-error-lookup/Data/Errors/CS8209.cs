namespace dotnet_error_lookup.Data.Errors;

public class CS8209 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8209";
    string IErrorOrWarning.Message => @"A value of type 'void' may not be assigned.";
    string IErrorOrWarning.Explanation => @"[original] A value of type 'void' may not be assigned.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
