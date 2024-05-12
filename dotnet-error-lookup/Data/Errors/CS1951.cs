namespace dotnet_error_lookup.Data.Errors;

public class CS1951 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1951";
    string IErrorOrWarning.Message => @"An expression tree lambda may not contain a ref, in or out parameter";
    string IErrorOrWarning.Explanation => @"[original] An expression tree lambda may not contain a ref, in or out parameter";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1951";
}
