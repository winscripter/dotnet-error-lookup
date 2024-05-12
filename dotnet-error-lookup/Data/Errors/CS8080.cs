namespace dotnet_error_lookup.Data.Errors;

public class CS8080 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8080";
    string IErrorOrWarning.Message => @"Auto-implemented properties must override all accessors of the overridden property.";
    string IErrorOrWarning.Explanation => @"[original] Auto-implemented properties must override all accessors of the overridden property.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
