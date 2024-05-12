namespace dotnet_error_lookup.Data.Errors;

public class CS0505 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0505";
    string IErrorOrWarning.Message => @"'{0}': cannot override because '{1}' is not a function";
    string IErrorOrWarning.Explanation => @"[original] '{0}': cannot override because '{1}' is not a function";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0505";
}
