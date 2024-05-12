namespace dotnet_error_lookup.Data.Errors;

public class CS8108 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8108";
    string IErrorOrWarning.Message => @"Cannot pass argument with dynamic type to params parameter '{0}' of local function '{1}'.";
    string IErrorOrWarning.Explanation => @"[original] Cannot pass argument with dynamic type to params parameter '{0}' of local function '{1}'.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
