namespace dotnet_error_lookup.Data.Errors;

public class CS7030 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS7030";
    string IErrorOrWarning.Message => @"Cannot pass null for friend assembly name";
    string IErrorOrWarning.Explanation => @"[original] Cannot pass null for friend assembly name";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
