namespace dotnet_error_lookup.Data.Errors;

public class CS0226 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0226";
    string IErrorOrWarning.Message => @"An \_\_arglist expression may only appear inside of a call or new expression";
    string IErrorOrWarning.Explanation => @"[original] An \_\_arglist expression may only appear inside of a call or new expression";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0226";
}
