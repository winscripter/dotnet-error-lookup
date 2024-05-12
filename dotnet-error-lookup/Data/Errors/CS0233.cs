namespace dotnet_error_lookup.Data.Errors;

public class CS0233 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0233";
    string IErrorOrWarning.Message => @"'{0}' does not have a predefined size, therefore sizeof can only be used in an unsafe context";
    string IErrorOrWarning.Explanation => @"[original] '{0}' does not have a predefined size, therefore sizeof can only be used in an unsafe context";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs0233";
}
