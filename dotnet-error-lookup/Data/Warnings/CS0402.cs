namespace dotnet_error_lookup.Data.Errors;

public class CS0402 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS0402";
    string IErrorOrWarning.Message => @"'{0}': an entry point cannot be generic or in a generic type";
    string IErrorOrWarning.Explanation => @"[original] '{0}': an entry point cannot be generic or in a generic type";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0402";
}
