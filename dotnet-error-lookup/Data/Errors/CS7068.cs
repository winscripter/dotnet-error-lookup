namespace dotnet_error_lookup.Data.Errors;

public class CS7068 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS7068";
    string IErrorOrWarning.Message => @"Reference to type '{0}' claims it is defined in this assembly, but it is not defined in source or any added modules";
    string IErrorOrWarning.Explanation => @"[original] Reference to type '{0}' claims it is defined in this assembly, but it is not defined in source or any added modules";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
