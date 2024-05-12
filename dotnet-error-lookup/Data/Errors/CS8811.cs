namespace dotnet_error_lookup.Data.Errors;

public class CS8811 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8811";
    string IErrorOrWarning.Message => @"Cannot convert &method group '{0}' to delegate type '{1}'.";
    string IErrorOrWarning.Explanation => @"[original] Cannot convert &method group '{0}' to delegate type '{1}'.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
