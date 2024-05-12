namespace dotnet_error_lookup.Data.Errors;

public class CS0426 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0426";
    string IErrorOrWarning.Message => @"The type name '{0}' does not exist in the type '{1}'";
    string IErrorOrWarning.Explanation => @"[original] The type name '{0}' does not exist in the type '{1}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0426";
}
