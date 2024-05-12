namespace dotnet_error_lookup.Data.Errors;

public class CS1952 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1952";
    string IErrorOrWarning.Message => @"An expression tree lambda may not contain a method with variable arguments";
    string IErrorOrWarning.Explanation => @"[original] An expression tree lambda may not contain a method with variable arguments";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1952";
}
