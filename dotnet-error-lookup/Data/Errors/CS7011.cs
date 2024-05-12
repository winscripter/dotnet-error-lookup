namespace dotnet_error_lookup.Data.Errors;

public class CS7011 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS7011";
    string IErrorOrWarning.Message => @"#r is only allowed in scripts";
    string IErrorOrWarning.Explanation => @"[original] #r is only allowed in scripts";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
