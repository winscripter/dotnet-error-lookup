namespace dotnet_error_lookup.Data.Errors;

public class CS1627 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1627";
    string IErrorOrWarning.Message => @"Expression expected after yield return";
    string IErrorOrWarning.Explanation => @"[original] Expression expected after yield return";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1627";
}
