namespace dotnet_error_lookup.Data.Errors;

public class CS1685 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS1685";
    string IErrorOrWarning.Message => @"The predefined type '{0}' is defined in multiple assemblies in the global alias; using definition from '{1}'";
    string IErrorOrWarning.Explanation => @"[original] The predefined type '{0}' is defined in multiple assemblies in the global alias; using definition from '{1}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs1685";
}
