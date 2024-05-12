namespace dotnet_error_lookup.Data.Errors;

public class CS0442 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0442";
    string IErrorOrWarning.Message => @"'{0}': abstract properties cannot have private accessors";
    string IErrorOrWarning.Explanation => @"[original] '{0}': abstract properties cannot have private accessors";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0442";
}
