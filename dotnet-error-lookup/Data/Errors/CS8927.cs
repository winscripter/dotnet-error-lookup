namespace dotnet_error_lookup.Data.Errors;

public class CS8927 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8927";
    string IErrorOrWarning.Message => @"An expression tree may not contain an access of static virtual or abstract interface member";
    string IErrorOrWarning.Explanation => @"[original] An expression tree may not contain an access of static virtual or abstract interface member";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
