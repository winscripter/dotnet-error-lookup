namespace dotnet_error_lookup.Data.Errors;

public class CS9071 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS9071";
    string IErrorOrWarning.Message => @"The namespace '{1}' already contains a definition for '{0}' in this file.";
    string IErrorOrWarning.Explanation => @"[original] The namespace '{1}' already contains a definition for '{0}' in this file.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
