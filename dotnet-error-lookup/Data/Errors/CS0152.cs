namespace dotnet_error_lookup.Data.Errors;

public class CS0152 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0152";
    string IErrorOrWarning.Message => @"The switch statement contains multiple cases with the label value '{0}'";
    string IErrorOrWarning.Explanation => @"[original] The switch statement contains multiple cases with the label value '{0}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0152";
}
