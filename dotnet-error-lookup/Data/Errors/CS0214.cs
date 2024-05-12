namespace dotnet_error_lookup.Data.Errors;

public class CS0214 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0214";
    string IErrorOrWarning.Message => @"Pointers and fixed size buffers may only be used in an unsafe context";
    string IErrorOrWarning.Explanation => @"[original] Pointers and fixed size buffers may only be used in an unsafe context";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0214";
}
