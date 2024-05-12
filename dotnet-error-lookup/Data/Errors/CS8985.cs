namespace dotnet_error_lookup.Data.Errors;

public class CS8985 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8985";
    string IErrorOrWarning.Message => @"List patterns may not be used for a value of type '{0}'. No suitable 'Length' or 'Count' property was found.";
    string IErrorOrWarning.Explanation => @"[original] List patterns may not be used for a value of type '{0}'. No suitable 'Length' or 'Count' property was found.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
