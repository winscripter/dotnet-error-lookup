namespace dotnet_error_lookup.Data.Errors;

public class CS1537 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1537";
    string IErrorOrWarning.Message => @"The using alias '{0}' appeared previously in this namespace";
    string IErrorOrWarning.Explanation => @"[original] The using alias '{0}' appeared previously in this namespace";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1537";
}
