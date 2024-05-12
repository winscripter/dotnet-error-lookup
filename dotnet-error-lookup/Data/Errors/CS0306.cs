namespace dotnet_error_lookup.Data.Errors;

public class CS0306 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0306";
    string IErrorOrWarning.Message => @"The type '{0}' may not be used as a type argument";
    string IErrorOrWarning.Explanation => @"[original] The type '{0}' may not be used as a type argument";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0306";
}
