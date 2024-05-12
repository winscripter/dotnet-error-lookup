namespace dotnet_error_lookup.Data.Errors;

public class CS0161 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0161";
    string IErrorOrWarning.Message => @"'{0}': not all code paths return a value";
    string IErrorOrWarning.Explanation => @"[original] '{0}': not all code paths return a value";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0161";
}
