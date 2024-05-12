namespace dotnet_error_lookup.Data.Errors;

public class CS1553 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1553";
    string IErrorOrWarning.Message => @"Declaration is not valid; use '{0} operator \<dest-type\> (...' instead";
    string IErrorOrWarning.Explanation => @"[original] Declaration is not valid; use '{0} operator \<dest-type\> (...' instead";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1553";
}
