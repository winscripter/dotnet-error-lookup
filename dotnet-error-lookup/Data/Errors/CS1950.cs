namespace dotnet_error_lookup.Data.Errors;

public class CS1950 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1950";
    string IErrorOrWarning.Message => @"The best overloaded Add method '{0}' for the collection initializer has some invalid arguments";
    string IErrorOrWarning.Explanation => @"[original] The best overloaded Add method '{0}' for the collection initializer has some invalid arguments";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1950";
}
