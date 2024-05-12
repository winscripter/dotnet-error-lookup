namespace dotnet_error_lookup.Data.Errors;

public class CS0522 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0522";
    string IErrorOrWarning.Message => @"'{0}': structs cannot call base class constructors";
    string IErrorOrWarning.Explanation => @"[original] '{0}': structs cannot call base class constructors";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0522";
}
