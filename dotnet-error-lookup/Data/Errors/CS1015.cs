namespace dotnet_error_lookup.Data.Errors;

public class CS1015 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1015";
    string IErrorOrWarning.Message => @"An object, string, or class type expected";
    string IErrorOrWarning.Explanation => @"[original] An object, string, or class type expected";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1015";
}
