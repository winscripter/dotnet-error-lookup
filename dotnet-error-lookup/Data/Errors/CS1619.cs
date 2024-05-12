namespace dotnet_error_lookup.Data.Errors;

public class CS1619 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1619";
    string IErrorOrWarning.Message => @"Cannot create temporary file -- {0}";
    string IErrorOrWarning.Explanation => @"[original] Cannot create temporary file -- {0}";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1619";
}
