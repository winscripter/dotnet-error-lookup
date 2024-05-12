namespace dotnet_error_lookup.Data.Errors;

public class CS0082 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0082";
    string IErrorOrWarning.Message => @"Type '{1}' already reserves a member called '{0}' with the same parameter types";
    string IErrorOrWarning.Explanation => @"[original] Type '{1}' already reserves a member called '{0}' with the same parameter types";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0082";
}
