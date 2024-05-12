namespace dotnet_error_lookup.Data.Errors;

public class CS8033 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS8033";
    string IErrorOrWarning.Message => @"The assembly {0} does not contain any analyzers.";
    string IErrorOrWarning.Explanation => @"[original] The assembly {0} does not contain any analyzers.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
