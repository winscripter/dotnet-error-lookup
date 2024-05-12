namespace dotnet_error_lookup.Data.Errors;

public class CS1942 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1942";
    string IErrorOrWarning.Message => @"The type of the expression in the {0} clause is incorrect.  Type inference failed in the call to '{1}'.";
    string IErrorOrWarning.Explanation => @"[original] The type of the expression in the {0} clause is incorrect.  Type inference failed in the call to '{1}'.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs1942";
}
