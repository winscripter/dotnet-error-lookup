namespace dotnet_error_lookup.Data.Errors;

public class CS1981 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS1981";
    string IErrorOrWarning.Message => @"Using '{0}' to test compatibility with '{1}' is essentially identical to testing compatibility with '{2}' and will succeed for all non-null values";
    string IErrorOrWarning.Explanation => @"[original] Using '{0}' to test compatibility with '{1}' is essentially identical to testing compatibility with '{2}' and will succeed for all non-null values";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
