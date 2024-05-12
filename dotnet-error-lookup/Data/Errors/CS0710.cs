namespace dotnet_error_lookup.Data.Errors;

public class CS0710 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0710";
    string IErrorOrWarning.Message => @"Static classes cannot have instance constructors";
    string IErrorOrWarning.Explanation => @"[original] Static classes cannot have instance constructors";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0710";
}
