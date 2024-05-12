namespace dotnet_error_lookup.Data.Errors;

public class CS8034 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS8034";
    string IErrorOrWarning.Message => @"Unable to load Analyzer assembly {0} : {1}";
    string IErrorOrWarning.Explanation => @"[original] Unable to load Analyzer assembly {0} : {1}";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
