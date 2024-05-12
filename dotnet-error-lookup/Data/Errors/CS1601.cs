namespace dotnet_error_lookup.Data.Errors;

public class CS1601 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1601";
    string IErrorOrWarning.Message => @"Cannot make reference to variable of type '{0}'";
    string IErrorOrWarning.Explanation => @"[original] Cannot make reference to variable of type '{0}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1601";
}
