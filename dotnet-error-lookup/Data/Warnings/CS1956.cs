namespace dotnet_error_lookup.Data.Errors;

public class CS1956 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS1956";
    string IErrorOrWarning.Message => @"Member '{0}' implements interface member '{1}' in type '{2}'. There are multiple matches for the interface member at run-time. It is implementation dependent which method will be called.";
    string IErrorOrWarning.Explanation => @"[original] Member '{0}' implements interface member '{1}' in type '{2}'. There are multiple matches for the interface member at run-time. It is implementation dependent which method will be called.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs1956";
}
