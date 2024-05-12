namespace dotnet_error_lookup.Data.Errors;

public class CS0507 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0507";
    string IErrorOrWarning.Message => @"'{0}': cannot change access modifiers when overriding '{1}' inherited member '{2}'";
    string IErrorOrWarning.Explanation => @"[original] '{0}': cannot change access modifiers when overriding '{1}' inherited member '{2}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs0507";
}
