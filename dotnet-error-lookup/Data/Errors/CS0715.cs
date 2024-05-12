namespace dotnet_error_lookup.Data.Errors;

public class CS0715 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0715";
    string IErrorOrWarning.Message => @"'{0}': static classes cannot contain user-defined operators";
    string IErrorOrWarning.Explanation => @"[original] '{0}': static classes cannot contain user-defined operators";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0715";
}
