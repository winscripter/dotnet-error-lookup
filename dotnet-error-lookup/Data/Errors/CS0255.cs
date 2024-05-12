namespace dotnet_error_lookup.Data.Errors;

public class CS0255 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0255";
    string IErrorOrWarning.Message => @"stackalloc may not be used in a catch or finally block";
    string IErrorOrWarning.Explanation => @"[original] stackalloc may not be used in a catch or finally block";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0255";
}
