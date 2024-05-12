namespace dotnet_error_lookup.Data.Errors;

public class CS0666 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0666";
    string IErrorOrWarning.Message => @"'{0}': new protected member declared in struct";
    string IErrorOrWarning.Explanation => @"[original] '{0}': new protected member declared in struct";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0666";
}
