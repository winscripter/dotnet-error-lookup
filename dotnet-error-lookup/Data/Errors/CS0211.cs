namespace dotnet_error_lookup.Data.Errors;

public class CS0211 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0211";
    string IErrorOrWarning.Message => @"Cannot take the address of the given expression";
    string IErrorOrWarning.Explanation => @"[original] Cannot take the address of the given expression";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0211";
}
