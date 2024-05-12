namespace dotnet_error_lookup.Data.Errors;

public class CS1581 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS1581";
    string IErrorOrWarning.Message => @"Invalid return type in XML comment cref attribute";
    string IErrorOrWarning.Explanation => @"[original] Invalid return type in XML comment cref attribute";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1581";
}
