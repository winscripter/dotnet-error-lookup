namespace dotnet_error_lookup.Data.Errors;

public class CS0815 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0815";
    string IErrorOrWarning.Message => @"Cannot assign {0} to an implicitly-typed variable";
    string IErrorOrWarning.Explanation => @"[original] Cannot assign {0} to an implicitly-typed variable";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0815";
}
