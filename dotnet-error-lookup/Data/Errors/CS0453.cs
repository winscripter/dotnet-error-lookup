namespace dotnet_error_lookup.Data.Errors;

public class CS0453 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0453";
    string IErrorOrWarning.Message => @"The type '{2}' must be a non-nullable value type in order to use it as parameter '{1}' in the generic type or method '{0}'";
    string IErrorOrWarning.Explanation => @"[original] The type '{2}' must be a non-nullable value type in order to use it as parameter '{1}' in the generic type or method '{0}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0453";
}
