namespace dotnet_error_lookup.Data.Errors;

public class CS0575 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0575";
    string IErrorOrWarning.Message => @"Only class types can contain destructors";
    string IErrorOrWarning.Explanation => @"[original] Only class types can contain destructors";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0575";
}
