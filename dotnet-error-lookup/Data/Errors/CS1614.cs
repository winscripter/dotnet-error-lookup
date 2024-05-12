namespace dotnet_error_lookup.Data.Errors;

public class CS1614 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1614";
    string IErrorOrWarning.Message => @"'{0}' is ambiguous between '{1}' and '{2}'. Either use '@{0}' or explicitly include the 'Attribute' suffix.";
    string IErrorOrWarning.Explanation => @"[original] '{0}' is ambiguous between '{1}' and '{2}'. Either use '@{0}' or explicitly include the 'Attribute' suffix.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs1614";
}
