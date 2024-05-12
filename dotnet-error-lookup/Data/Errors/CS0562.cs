namespace dotnet_error_lookup.Data.Errors;

public class CS0562 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0562";
    string IErrorOrWarning.Message => @"The parameter of a unary operator must be the containing type";
    string IErrorOrWarning.Explanation => @"[original] The parameter of a unary operator must be the containing type";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0562";
}
