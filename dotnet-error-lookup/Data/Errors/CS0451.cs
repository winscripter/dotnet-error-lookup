namespace dotnet_error_lookup.Data.Errors;

public class CS0451 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0451";
    string IErrorOrWarning.Message => @"The 'new()' constraint cannot be used with the 'struct' constraint";
    string IErrorOrWarning.Explanation => @"[original] The 'new()' constraint cannot be used with the 'struct' constraint";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0451";
}
