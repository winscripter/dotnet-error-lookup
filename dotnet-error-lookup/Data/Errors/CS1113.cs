namespace dotnet_error_lookup.Data.Errors;

public class CS1113 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1113";
    string IErrorOrWarning.Message => @"Extension method '{0}' defined on value type '{1}' cannot be used to create delegates";
    string IErrorOrWarning.Explanation => @"[original] Extension method '{0}' defined on value type '{1}' cannot be used to create delegates";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1113";
}
