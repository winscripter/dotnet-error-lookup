namespace dotnet_error_lookup.Data.Errors;

public class CS3015 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS3015";
    string IErrorOrWarning.Message => @"'{0}' has no accessible constructors which use only CLS-compliant types";
    string IErrorOrWarning.Explanation => @"[original] '{0}' has no accessible constructors which use only CLS-compliant types";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs3015";
}
