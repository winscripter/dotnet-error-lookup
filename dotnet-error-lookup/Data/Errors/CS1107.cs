namespace dotnet_error_lookup.Data.Errors;

public class CS1107 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1107";
    string IErrorOrWarning.Message => @"A parameter can only have one '{0}' modifier";
    string IErrorOrWarning.Explanation => @"[original] A parameter can only have one '{0}' modifier";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1107";
}
