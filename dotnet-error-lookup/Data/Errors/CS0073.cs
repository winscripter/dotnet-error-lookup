namespace dotnet_error_lookup.Data.Errors;

public class CS0073 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0073";
    string IErrorOrWarning.Message => @"An add or remove accessor must have a body";
    string IErrorOrWarning.Explanation => @"[original] An add or remove accessor must have a body";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0073";
}
