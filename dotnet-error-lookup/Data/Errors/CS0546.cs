namespace dotnet_error_lookup.Data.Errors;

public class CS0546 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0546";
    string IErrorOrWarning.Message => @"'{0}': cannot override because '{1}' does not have an overridable set accessor";
    string IErrorOrWarning.Explanation => @"[original] '{0}': cannot override because '{1}' does not have an overridable set accessor";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0546";
}
