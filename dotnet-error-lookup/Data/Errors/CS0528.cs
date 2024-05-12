namespace dotnet_error_lookup.Data.Errors;

public class CS0528 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0528";
    string IErrorOrWarning.Message => @"'{0}' is already listed in interface list";
    string IErrorOrWarning.Explanation => @"[original] '{0}' is already listed in interface list";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0528";
}
