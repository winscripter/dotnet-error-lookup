namespace dotnet_error_lookup.Data.Errors;

public class CS1723 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS1723";
    string IErrorOrWarning.Message => @"XML comment has cref attribute '{0}' that refers to a type parameter";
    string IErrorOrWarning.Explanation => @"[original] XML comment has cref attribute '{0}' that refers to a type parameter";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1723";
}
