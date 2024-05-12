namespace dotnet_error_lookup.Data.Errors;

public class CS0105 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS0105";
    string IErrorOrWarning.Message => @"The using directive for '{0}' appeared previously in this namespace";
    string IErrorOrWarning.Explanation => @"[original] The using directive for '{0}' appeared previously in this namespace";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0105";
}
