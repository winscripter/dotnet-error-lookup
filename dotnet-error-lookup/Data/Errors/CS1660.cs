namespace dotnet_error_lookup.Data.Errors;

public class CS1660 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1660";
    string IErrorOrWarning.Message => @"Cannot convert {0} to type '{1}' because it is not a delegate type";
    string IErrorOrWarning.Explanation => @"[original] Cannot convert {0} to type '{1}' because it is not a delegate type";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1660";
}
