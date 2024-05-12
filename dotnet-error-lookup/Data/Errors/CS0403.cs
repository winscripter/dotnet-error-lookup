namespace dotnet_error_lookup.Data.Errors;

public class CS0403 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0403";
    string IErrorOrWarning.Message => @"Cannot convert null to type parameter '{0}' because it could be a non-nullable value type. Consider using 'default({0})' instead.";
    string IErrorOrWarning.Explanation => @"[original] Cannot convert null to type parameter '{0}' because it could be a non-nullable value type. Consider using 'default({0})' instead.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0403";
}
