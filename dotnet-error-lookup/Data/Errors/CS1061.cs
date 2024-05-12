namespace dotnet_error_lookup.Data.Errors;

public class CS1061 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1061";
    string IErrorOrWarning.Message => @"'{0}' does not contain a definition for '{1}' and no accessible extension method '{1}' accepting a first argument of type '{0}' could be found (are you missing a using directive or an assembly reference?)";
    string IErrorOrWarning.Explanation => @"[original] '{0}' does not contain a definition for '{1}' and no accessible extension method '{1}' accepting a first argument of type '{0}' could be found (are you missing a using directive or an assembly reference?)";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs1061";
}
