namespace dotnet_error_lookup.Data.Errors;

public class CS0016 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0016";
    string IErrorOrWarning.Message => @"Could not write to output file '{0}' -- '{1}'";
    string IErrorOrWarning.Explanation => @"[original] Could not write to output file '{0}' -- '{1}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs0016";
}
