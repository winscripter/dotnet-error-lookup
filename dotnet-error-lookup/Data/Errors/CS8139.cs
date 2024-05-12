namespace dotnet_error_lookup.Data.Errors;

public class CS8139 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8139";
    string IErrorOrWarning.Message => @"'{0}': cannot change tuple element names when overriding inherited member '{1}'";
    string IErrorOrWarning.Explanation => @"[original] '{0}': cannot change tuple element names when overriding inherited member '{1}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs8139";
}
