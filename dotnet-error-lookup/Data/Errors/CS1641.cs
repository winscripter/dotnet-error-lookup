namespace dotnet_error_lookup.Data.Errors;

public class CS1641 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1641";
    string IErrorOrWarning.Message => @"A fixed size buffer field must have the array size specifier after the field name";
    string IErrorOrWarning.Explanation => @"[original] A fixed size buffer field must have the array size specifier after the field name";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1641";
}
