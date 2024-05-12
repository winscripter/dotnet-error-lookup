namespace dotnet_error_lookup.Data.Errors;

public class CS1910 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1910";
    string IErrorOrWarning.Message => @"Argument of type '{0}' is not applicable for the DefaultParameterValue attribute";
    string IErrorOrWarning.Explanation => @"[original] Argument of type '{0}' is not applicable for the DefaultParameterValue attribute";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1910";
}
