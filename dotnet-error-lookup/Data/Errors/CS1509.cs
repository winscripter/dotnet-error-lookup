namespace dotnet_error_lookup.Data.Errors;

public class CS1509 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1509";
    string IErrorOrWarning.Message => @"The referenced file '{0}' is not an assembly";
    string IErrorOrWarning.Explanation => @"[original] The referenced file '{0}' is not an assembly";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1509";
}
