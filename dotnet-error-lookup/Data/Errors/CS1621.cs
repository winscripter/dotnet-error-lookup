namespace dotnet_error_lookup.Data.Errors;

public class CS1621 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1621";
    string IErrorOrWarning.Message => @"The yield statement cannot be used inside an anonymous method or lambda expression";
    string IErrorOrWarning.Explanation => @"[original] The yield statement cannot be used inside an anonymous method or lambda expression";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1621";
}
