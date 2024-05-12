namespace dotnet_error_lookup.Data.Errors;

public class CS0209 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0209";
    string IErrorOrWarning.Message => @"The type of a local declared in a fixed statement must be a pointer type";
    string IErrorOrWarning.Explanation => @"[original] The type of a local declared in a fixed statement must be a pointer type";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0209";
}
