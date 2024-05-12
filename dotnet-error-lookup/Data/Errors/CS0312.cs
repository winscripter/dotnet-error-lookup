namespace dotnet_error_lookup.Data.Errors;

public class CS0312 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0312";
    string IErrorOrWarning.Message => @"The type '{3}' cannot be used as type parameter '{2}' in the generic type or method '{0}'. The nullable type '{3}' does not satisfy the constraint of '{1}'.";
    string IErrorOrWarning.Explanation => @"[original] The type '{3}' cannot be used as type parameter '{2}' in the generic type or method '{0}'. The nullable type '{3}' does not satisfy the constraint of '{1}'.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0312";
}
