namespace dotnet_error_lookup.Data.Errors;

public class CS1721 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1721";
    string IErrorOrWarning.Message => @"Class '{0}' cannot have multiple base classes: '{1}' and '{2}'";
    string IErrorOrWarning.Explanation => @"[original] Class '{0}' cannot have multiple base classes: '{1}' and '{2}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs1721";
}
