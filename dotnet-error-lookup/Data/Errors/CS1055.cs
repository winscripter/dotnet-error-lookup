namespace dotnet_error_lookup.Data.Errors;

public class CS1055 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1055";
    string IErrorOrWarning.Message => @"An add or remove accessor expected";
    string IErrorOrWarning.Explanation => @"[original] An add or remove accessor expected";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1055";
}
