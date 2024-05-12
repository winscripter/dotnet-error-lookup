namespace dotnet_error_lookup.Data.Errors;

public class CS0231 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0231";
    string IErrorOrWarning.Message => @"A params parameter must be the last parameter in a parameter list";
    string IErrorOrWarning.Explanation => @"[original] A params parameter must be the last parameter in a parameter list";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0231";
}
