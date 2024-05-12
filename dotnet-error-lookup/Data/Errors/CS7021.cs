namespace dotnet_error_lookup.Data.Errors;

public class CS7021 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS7021";
    string IErrorOrWarning.Message => @"Cannot declare namespace in script code";
    string IErrorOrWarning.Explanation => @"[original] Cannot declare namespace in script code";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
