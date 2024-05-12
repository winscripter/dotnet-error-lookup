namespace dotnet_error_lookup.Data.Errors;

public class CS1958 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1958";
    string IErrorOrWarning.Message => @"Object and collection initializer expressions may not be applied to a delegate creation expression";
    string IErrorOrWarning.Explanation => @"[original] Object and collection initializer expressions may not be applied to a delegate creation expression";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1958";
}
