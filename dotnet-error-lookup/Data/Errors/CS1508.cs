namespace dotnet_error_lookup.Data.Errors;

public class CS1508 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1508";
    string IErrorOrWarning.Message => @"Resource identifier '{0}' has already been used in this assembly";
    string IErrorOrWarning.Explanation => @"[original] Resource identifier '{0}' has already been used in this assembly";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1508";
}
