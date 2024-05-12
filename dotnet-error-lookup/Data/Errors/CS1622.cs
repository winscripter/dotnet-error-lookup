namespace dotnet_error_lookup.Data.Errors;

public class CS1622 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1622";
    string IErrorOrWarning.Message => @"Cannot return a value from an iterator. Use the yield return statement to return a value, or yield break to end the iteration.";
    string IErrorOrWarning.Explanation => @"[original] Cannot return a value from an iterator. Use the yield return statement to return a value, or yield break to end the iteration.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1622";
}
