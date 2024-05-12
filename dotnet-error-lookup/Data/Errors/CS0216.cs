namespace dotnet_error_lookup.Data.Errors;

public class CS0216 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0216";
    string IErrorOrWarning.Message => @"The operator '{0}' requires a matching operator '{1}' to also be defined";
    string IErrorOrWarning.Explanation => @"[original] The operator '{0}' requires a matching operator '{1}' to also be defined";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0216";
}
