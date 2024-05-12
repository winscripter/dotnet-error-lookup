namespace dotnet_error_lookup.Data.Errors;

public class CS7086 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS7086";
    string IErrorOrWarning.Message => @"Module name '{0}' stored in '{1}' must match its filename.";
    string IErrorOrWarning.Explanation => @"[original] Module name '{0}' stored in '{1}' must match its filename.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
