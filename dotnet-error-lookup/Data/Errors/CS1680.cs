namespace dotnet_error_lookup.Data.Errors;

public class CS1680 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1680";
    string IErrorOrWarning.Message => @"Invalid reference alias option: '{0}=' -- missing filename";
    string IErrorOrWarning.Explanation => @"[original] Invalid reference alias option: '{0}=' -- missing filename";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1680";
}
