namespace dotnet_error_lookup.Data.Errors;

public class CS1103 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1103";
    string IErrorOrWarning.Message => @"The first parameter of an extension method cannot be of type '{0}'";
    string IErrorOrWarning.Explanation => @"[original] The first parameter of an extension method cannot be of type '{0}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1103";
}
