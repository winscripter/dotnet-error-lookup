namespace dotnet_error_lookup.Data.Errors;

public class CS0448 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0448";
    string IErrorOrWarning.Message => @"The return type for ++ or -- operator must match the parameter type or be derived from the parameter type";
    string IErrorOrWarning.Explanation => @"[original] The return type for ++ or -- operator must match the parameter type or be derived from the parameter type";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0448";
}
