namespace dotnet_error_lookup.Data.Errors;

public class CS0283 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0283";
    string IErrorOrWarning.Message => @"The type '{0}' cannot be declared const";
    string IErrorOrWarning.Explanation => @"[original] The type '{0}' cannot be declared const";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0283";
}
