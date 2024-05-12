namespace dotnet_error_lookup.Data.Errors;

public class CS1575 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1575";
    string IErrorOrWarning.Message => @"A stackalloc expression requires [] after type";
    string IErrorOrWarning.Explanation => @"[original] A stackalloc expression requires [] after type";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1575";
}
