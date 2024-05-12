namespace dotnet_error_lookup.Data.Errors;

public class CS8357 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8357";
    string IErrorOrWarning.Message => @"The specified version string '{0}' contains wildcards, which are not compatible with determinism. Either remove wildcards from the version string, or disable determinism for this compilation";
    string IErrorOrWarning.Explanation => @"[original] The specified version string '{0}' contains wildcards, which are not compatible with determinism. Either remove wildcards from the version string, or disable determinism for this compilation";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
