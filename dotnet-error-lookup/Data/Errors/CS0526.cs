namespace dotnet_error_lookup.Data.Errors;

public class CS0526 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0526";
    string IErrorOrWarning.Message => @"Interfaces cannot contain instance constructors";
    string IErrorOrWarning.Explanation => @"[original] Interfaces cannot contain instance constructors";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0526";
}
