namespace dotnet_error_lookup.Data.Errors;

public class CS0523 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0523";
    string IErrorOrWarning.Message => @"Struct member '{0}' of type '{1}' causes a cycle in the struct layout";
    string IErrorOrWarning.Explanation => @"[original] Struct member '{0}' of type '{1}' causes a cycle in the struct layout";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs0523";
}
