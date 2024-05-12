namespace dotnet_error_lookup.Data.Errors;

public class CS8714 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS8714";
    string IErrorOrWarning.Message => @"The type '{2}' cannot be used as type parameter '{1}' in the generic type or method '{0}'. Nullability of type argument '{2}' doesn't match 'notnull' constraint.";
    string IErrorOrWarning.Explanation => @"[original] The type '{2}' cannot be used as type parameter '{1}' in the generic type or method '{0}'. Nullability of type argument '{2}' doesn't match 'notnull' constraint.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/nullable-warnings";
}
