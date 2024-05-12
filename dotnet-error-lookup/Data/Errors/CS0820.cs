namespace dotnet_error_lookup.Data.Errors;

public class CS0820 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0820";
    string IErrorOrWarning.Message => @"Cannot initialize an implicitly-typed variable with an array initializer";
    string IErrorOrWarning.Explanation => @"[original] Cannot initialize an implicitly-typed variable with an array initializer";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0820";
}
