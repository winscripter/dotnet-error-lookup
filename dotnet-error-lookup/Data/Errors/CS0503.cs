namespace dotnet_error_lookup.Data.Errors;

public class CS0503 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0503";
    string IErrorOrWarning.Message => @"The abstract {0} '{1}' cannot be marked virtual";
    string IErrorOrWarning.Explanation => @"[original] The abstract {0} '{1}' cannot be marked virtual";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0503";
}
