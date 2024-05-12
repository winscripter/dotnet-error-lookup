namespace dotnet_error_lookup.Data.Errors;

public class CS0110 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0110";
    string IErrorOrWarning.Message => @"The evaluation of the constant value for '{0}' involves a circular definition";
    string IErrorOrWarning.Explanation => @"[original] The evaluation of the constant value for '{0}' involves a circular definition";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0110";
}
