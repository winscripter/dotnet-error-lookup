namespace dotnet_error_lookup.Data.Errors;

public class CS1673 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1673";
    string IErrorOrWarning.Message => @"Anonymous methods, lambda expressions, query expressions, and local functions inside structs cannot access instance members of 'this'. Consider copying 'this' to a local variable outside the anonymous method, lambda expression, query expression, or local function and using the local instead.";
    string IErrorOrWarning.Explanation => @"[original] Anonymous methods, lambda expressions, query expressions, and local functions inside structs cannot access instance members of 'this'. Consider copying 'this' to a local variable outside the anonymous method, lambda expression, query expression, or local function and using the local instead.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1673";
}
