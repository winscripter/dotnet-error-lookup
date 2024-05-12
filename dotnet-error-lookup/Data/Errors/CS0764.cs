namespace dotnet_error_lookup.Data.Errors;

public class CS0764 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0764";
    string IErrorOrWarning.Message => @"Both partial method declarations must be unsafe or neither may be unsafe";
    string IErrorOrWarning.Explanation => @"[original] Both partial method declarations must be unsafe or neither may be unsafe";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0764";
}
