namespace dotnet_error_lookup.Data.Errors;

public class CS1661 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1661";
    string IErrorOrWarning.Message => @"Cannot convert {0} to type '{1}' because the parameter types do not match the delegate parameter types";
    string IErrorOrWarning.Explanation => @"[original] Cannot convert {0} to type '{1}' because the parameter types do not match the delegate parameter types";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1661";
}
