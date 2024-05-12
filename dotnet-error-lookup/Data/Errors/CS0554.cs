namespace dotnet_error_lookup.Data.Errors;

public class CS0554 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0554";
    string IErrorOrWarning.Message => @"'{0}': user-defined conversions to or from a derived type are not allowed";
    string IErrorOrWarning.Explanation => @"[original] '{0}': user-defined conversions to or from a derived type are not allowed";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0554";
}
