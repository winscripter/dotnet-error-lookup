namespace dotnet_error_lookup.Data.Errors;

public class CS0763 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0763";
    string IErrorOrWarning.Message => @"Both partial method declarations must be static or neither may be static";
    string IErrorOrWarning.Explanation => @"[original] Both partial method declarations must be static or neither may be static";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0763";
}
