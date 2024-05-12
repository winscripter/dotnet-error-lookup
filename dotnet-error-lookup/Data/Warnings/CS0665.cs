namespace dotnet_error_lookup.Data.Errors;

public class CS0665 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS0665";
    string IErrorOrWarning.Message => @"Assignment in conditional expression is always constant; did you mean to use == instead of = ?";
    string IErrorOrWarning.Explanation => @"[original] Assignment in conditional expression is always constant; did you mean to use == instead of = ?";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0665";
}
