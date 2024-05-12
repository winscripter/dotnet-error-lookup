namespace dotnet_error_lookup.Data.Errors;

public class CS0028 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS0028";
    string IErrorOrWarning.Message => @"'{0}' has the wrong signature to be an entry point";
    string IErrorOrWarning.Explanation => @"[original] '{0}' has the wrong signature to be an entry point";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0028";
}
