namespace dotnet_error_lookup.Data.Errors;

public class CS1552 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1552";
    string IErrorOrWarning.Message => @"Array type specifier, [], must appear before parameter name";
    string IErrorOrWarning.Explanation => @"[original] Array type specifier, [], must appear before parameter name";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1552";
}
