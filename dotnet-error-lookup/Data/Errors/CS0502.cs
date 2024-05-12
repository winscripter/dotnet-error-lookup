namespace dotnet_error_lookup.Data.Errors;

public class CS0502 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0502";
    string IErrorOrWarning.Message => @"'{0}' cannot be both abstract and sealed";
    string IErrorOrWarning.Explanation => @"[original] '{0}' cannot be both abstract and sealed";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0502";
}
