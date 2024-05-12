namespace dotnet_error_lookup.Data.Errors;

public class CS7023 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS7023";
    string IErrorOrWarning.Message => @"The second operand of an 'is' or 'as' operator may not be static type '{0}'";
    string IErrorOrWarning.Explanation => @"[original] The second operand of an 'is' or 'as' operator may not be static type '{0}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/warning-waves";
}
