namespace dotnet_error_lookup.Data.Errors;

public class CS0242 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0242";
    string IErrorOrWarning.Message => @"The operation in question is undefined on void pointers";
    string IErrorOrWarning.Explanation => @"[original] The operation in question is undefined on void pointers";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0242";
}
