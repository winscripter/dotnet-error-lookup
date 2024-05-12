namespace dotnet_error_lookup.Data.Errors;

public class CS0072 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0072";
    string IErrorOrWarning.Message => @"'{0}': cannot override; '{1}' is not an event";
    string IErrorOrWarning.Explanation => @"[original] '{0}': cannot override; '{1}' is not an event";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0072";
}
