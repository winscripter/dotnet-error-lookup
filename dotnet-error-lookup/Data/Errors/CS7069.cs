namespace dotnet_error_lookup.Data.Errors;

public class CS7069 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS7069";
    string IErrorOrWarning.Message => @"Reference to type '{0}' claims it is defined in '{1}', but it could not be found";
    string IErrorOrWarning.Explanation => @"[original] Reference to type '{0}' claims it is defined in '{1}', but it could not be found";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
