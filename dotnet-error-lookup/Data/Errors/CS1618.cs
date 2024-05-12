namespace dotnet_error_lookup.Data.Errors;

public class CS1618 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1618";
    string IErrorOrWarning.Message => @"Cannot create delegate with '{0}' because it or a method it overrides has a Conditional attribute";
    string IErrorOrWarning.Explanation => @"[original] Cannot create delegate with '{0}' because it or a method it overrides has a Conditional attribute";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1618";
}
