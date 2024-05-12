namespace dotnet_error_lookup.Data.Errors;

public class CS0245 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0245";
    string IErrorOrWarning.Message => @"Destructors and object.Finalize cannot be called directly. Consider calling IDisposable.Dispose if available.";
    string IErrorOrWarning.Explanation => @"[original] Destructors and object.Finalize cannot be called directly. Consider calling IDisposable.Dispose if available.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0245";
}
