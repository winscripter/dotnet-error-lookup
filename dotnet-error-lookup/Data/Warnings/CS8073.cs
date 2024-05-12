namespace dotnet_error_lookup.Data.Errors;

public class CS8073 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS8073";
    string IErrorOrWarning.Message => @"The result of the expression is always '{0}' since a value of type '{1}' is never equal to 'null' of type '{2}'";
    string IErrorOrWarning.Explanation => @"[original] The result of the expression is always '{0}' since a value of type '{1}' is never equal to 'null' of type '{2}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/warning-waves";
}
