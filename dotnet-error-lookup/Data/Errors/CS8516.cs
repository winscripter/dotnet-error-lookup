namespace dotnet_error_lookup.Data.Errors;

public class CS8516 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8516";
    string IErrorOrWarning.Message => @"The name '{0}' does not identify tuple element '{1}'.";
    string IErrorOrWarning.Explanation => @"[original] The name '{0}' does not identify tuple element '{1}'.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
