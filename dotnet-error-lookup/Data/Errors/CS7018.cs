namespace dotnet_error_lookup.Data.Errors;

public class CS7018 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS7018";
    string IErrorOrWarning.Message => @"Expected a script (.csx file) but none specified";
    string IErrorOrWarning.Explanation => @"[original] Expected a script (.csx file) but none specified";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
