namespace dotnet_error_lookup.Data.Errors;

public class CS0714 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0714";
    string IErrorOrWarning.Message => @"'{0}': static classes cannot implement interfaces";
    string IErrorOrWarning.Explanation => @"[original] '{0}': static classes cannot implement interfaces";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0714";
}
