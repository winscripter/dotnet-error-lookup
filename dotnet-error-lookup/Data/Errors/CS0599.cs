namespace dotnet_error_lookup.Data.Errors;

public class CS0599 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0599";
    string IErrorOrWarning.Message => @"Invalid value for named attribute argument '{0}'";
    string IErrorOrWarning.Explanation => @"[original] Invalid value for named attribute argument '{0}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0599";
}
