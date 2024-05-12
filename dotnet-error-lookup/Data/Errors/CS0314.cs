namespace dotnet_error_lookup.Data.Errors;

public class CS0314 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0314";
    string IErrorOrWarning.Message => @"The type '{3}' cannot be used as type parameter '{2}' in the generic type or method '{0}'. There is no boxing conversion or type parameter conversion from '{3}' to '{1}'.";
    string IErrorOrWarning.Explanation => @"[original] The type '{3}' cannot be used as type parameter '{2}' in the generic type or method '{0}'. There is no boxing conversion or type parameter conversion from '{3}' to '{1}'.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0314";
}
