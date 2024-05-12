namespace dotnet_error_lookup.Data.Errors;

public class CS0174 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0174";
    string IErrorOrWarning.Message => @"A base class is required for a 'base' reference";
    string IErrorOrWarning.Explanation => @"[original] A base class is required for a 'base' reference";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0174";
}
