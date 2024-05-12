namespace dotnet_error_lookup.Data.Errors;

public class CS1654 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1654";
    string IErrorOrWarning.Message => @"Cannot modify members of '{0}' because it is a '{1}'";
    string IErrorOrWarning.Explanation => @"[original] Cannot modify members of '{0}' because it is a '{1}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1654";
}
