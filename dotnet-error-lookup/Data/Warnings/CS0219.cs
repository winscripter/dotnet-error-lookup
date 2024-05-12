namespace dotnet_error_lookup.Data.Errors;

public class CS0219 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS0219";
    string IErrorOrWarning.Message => @"The variable '{0}' is assigned but its value is never used";
    string IErrorOrWarning.Explanation => @"[original] The variable '{0}' is assigned but its value is never used";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0219";
}
