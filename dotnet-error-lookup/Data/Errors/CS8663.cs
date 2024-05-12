namespace dotnet_error_lookup.Data.Errors;

public class CS8663 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8663";
    string IErrorOrWarning.Message => @"Both partial method declarations must be readonly or neither may be readonly";
    string IErrorOrWarning.Explanation => @"[original] Both partial method declarations must be readonly or neither may be readonly";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
