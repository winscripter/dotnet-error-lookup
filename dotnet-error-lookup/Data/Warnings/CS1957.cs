namespace dotnet_error_lookup.Data.Errors;

public class CS1957 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS1957";
    string IErrorOrWarning.Message => @"Member '{1}' overrides '{0}'. There are multiple override candidates at run-time. It is implementation dependent which method will be called. Please use a newer runtime.";
    string IErrorOrWarning.Explanation => @"[original] Member '{1}' overrides '{0}'. There are multiple override candidates at run-time. It is implementation dependent which method will be called. Please use a newer runtime.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1957";
}
