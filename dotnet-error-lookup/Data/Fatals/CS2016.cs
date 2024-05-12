namespace dotnet_error_lookup.Data.Errors;

public class CS2016 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Fatal;
    string IErrorOrWarning.Name => @"CS2016";
    string IErrorOrWarning.Message => @"Code page '{0}' is invalid or not installed";
    string IErrorOrWarning.Explanation => @"[original] Code page '{0}' is invalid or not installed";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs2016";
}
