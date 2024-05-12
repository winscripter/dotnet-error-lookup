namespace dotnet_error_lookup.Data.Errors;

public class CS1007 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1007";
    string IErrorOrWarning.Message => @"Property accessor already defined";
    string IErrorOrWarning.Explanation => @"[original] Property accessor already defined";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1007";
}
