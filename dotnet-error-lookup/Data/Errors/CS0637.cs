namespace dotnet_error_lookup.Data.Errors;

public class CS0637 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0637";
    string IErrorOrWarning.Message => @"The FieldOffset attribute is not allowed on static or const fields";
    string IErrorOrWarning.Explanation => @"[original] The FieldOffset attribute is not allowed on static or const fields";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0637";
}
