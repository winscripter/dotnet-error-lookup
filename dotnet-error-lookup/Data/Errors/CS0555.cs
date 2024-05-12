namespace dotnet_error_lookup.Data.Errors;

public class CS0555 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0555";
    string IErrorOrWarning.Message => @"User-defined operator cannot convert a type to itself";
    string IErrorOrWarning.Explanation => @"[original] User-defined operator cannot convert a type to itself";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0555";
}
