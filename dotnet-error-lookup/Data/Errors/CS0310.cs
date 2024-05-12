namespace dotnet_error_lookup.Data.Errors;

public class CS0310 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0310";
    string IErrorOrWarning.Message => @"'{2}' must be a non-abstract type with a public parameterless constructor in order to use it as parameter '{1}' in the generic type or method '{0}'";
    string IErrorOrWarning.Explanation => @"[original] '{2}' must be a non-abstract type with a public parameterless constructor in order to use it as parameter '{1}' in the generic type or method '{0}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs0310";
}
