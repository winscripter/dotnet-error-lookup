namespace dotnet_error_lookup.Data.Errors;

public class CS0113 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0113";
    string IErrorOrWarning.Message => @"A member '{0}' marked as override cannot be marked as new or virtual";
    string IErrorOrWarning.Explanation => @"[original] A member '{0}' marked as override cannot be marked as new or virtual";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0113";
}
