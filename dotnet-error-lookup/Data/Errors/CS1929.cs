namespace dotnet_error_lookup.Data.Errors;

public class CS1929 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1929";
    string IErrorOrWarning.Message => @"'{0}' does not contain a definition for '{1}' and the best extension method overload '{2}' requires a receiver of type '{3}'";
    string IErrorOrWarning.Explanation => @"[original] '{0}' does not contain a definition for '{1}' and the best extension method overload '{2}' requires a receiver of type '{3}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1929";
}
