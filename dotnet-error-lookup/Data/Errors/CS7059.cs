namespace dotnet_error_lookup.Data.Errors;

public class CS7059 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS7059";
    string IErrorOrWarning.Message => @"Executables cannot be satellite assemblies; culture should always be empty";
    string IErrorOrWarning.Explanation => @"[original] Executables cannot be satellite assemblies; culture should always be empty";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
