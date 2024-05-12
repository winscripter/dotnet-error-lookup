namespace dotnet_error_lookup.Data.Errors;

public class CS0717 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0717";
    string IErrorOrWarning.Message => @"'{0}': static classes cannot be used as constraints";
    string IErrorOrWarning.Explanation => @"[original] '{0}': static classes cannot be used as constraints";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0717";
}
