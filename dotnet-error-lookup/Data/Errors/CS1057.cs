namespace dotnet_error_lookup.Data.Errors;

public class CS1057 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1057";
    string IErrorOrWarning.Message => @"'{0}': static classes cannot contain protected members";
    string IErrorOrWarning.Explanation => @"[original] '{0}': static classes cannot contain protected members";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1057";
}
