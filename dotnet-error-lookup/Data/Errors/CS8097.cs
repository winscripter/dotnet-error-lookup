namespace dotnet_error_lookup.Data.Errors;

public class CS8097 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8097";
    string IErrorOrWarning.Message => @"#load is only allowed in scripts";
    string IErrorOrWarning.Explanation => @"[original] #load is only allowed in scripts";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
