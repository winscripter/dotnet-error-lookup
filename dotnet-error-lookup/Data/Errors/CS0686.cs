namespace dotnet_error_lookup.Data.Errors;

public class CS0686 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0686";
    string IErrorOrWarning.Message => @"Accessor '{0}' cannot implement interface member '{1}' for type '{2}'. Use an explicit interface implementation.";
    string IErrorOrWarning.Explanation => @"[original] Accessor '{0}' cannot implement interface member '{1}' for type '{2}'. Use an explicit interface implementation.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs0686";
}
