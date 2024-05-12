namespace dotnet_error_lookup.Data.Errors;

public class CS0230 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0230";
    string IErrorOrWarning.Message => @"Type and identifier are both required in a foreach statement";
    string IErrorOrWarning.Explanation => @"[original] Type and identifier are both required in a foreach statement";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0230";
}
