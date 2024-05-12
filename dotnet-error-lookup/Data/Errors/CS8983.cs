namespace dotnet_error_lookup.Data.Errors;

public class CS8983 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8983";
    string IErrorOrWarning.Message => @"A 'struct' with field initializers must include an explicitly declared constructor.";
    string IErrorOrWarning.Explanation => @"[original] A 'struct' with field initializers must include an explicitly declared constructor.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
