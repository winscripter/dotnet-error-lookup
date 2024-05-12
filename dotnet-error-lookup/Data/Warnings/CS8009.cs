namespace dotnet_error_lookup.Data.Errors;

public class CS8009 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS8009";
    string IErrorOrWarning.Message => @"Referenced assembly '{0}' has different culture setting of '{1}'.";
    string IErrorOrWarning.Explanation => @"[original] Referenced assembly '{0}' has different culture setting of '{1}'.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
