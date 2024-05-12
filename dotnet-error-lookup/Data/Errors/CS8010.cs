namespace dotnet_error_lookup.Data.Errors;

public class CS8010 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8010";
    string IErrorOrWarning.Message => @"Agnostic assembly cannot have a processor specific module '{0}'.";
    string IErrorOrWarning.Explanation => @"[original] Agnostic assembly cannot have a processor specific module '{0}'.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
