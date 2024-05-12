namespace dotnet_error_lookup.Data.Errors;

public class CS8132 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8132";
    string IErrorOrWarning.Message => @"Cannot deconstruct a tuple of '{0}' elements into '{1}' variables.";
    string IErrorOrWarning.Explanation => @"[original] Cannot deconstruct a tuple of '{0}' elements into '{1}' variables.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs8132";
}
