namespace dotnet_error_lookup.Data.Errors;

public class CS0755 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0755";
    string IErrorOrWarning.Message => @"Both partial method declarations must be extension methods or neither may be an extension method";
    string IErrorOrWarning.Explanation => @"[original] Both partial method declarations must be extension methods or neither may be an extension method";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0755";
}
