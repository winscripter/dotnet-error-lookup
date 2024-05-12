namespace dotnet_error_lookup.Data.Errors;

public class CS0225 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0225";
    string IErrorOrWarning.Message => @"The params parameter must be a single dimensional array";
    string IErrorOrWarning.Explanation => @"[original] The params parameter must be a single dimensional array";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0225";
}
