namespace dotnet_error_lookup.Data.Errors;

public class CS0430 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0430";
    string IErrorOrWarning.Message => @"The extern alias '{0}' was not specified in a /reference option";
    string IErrorOrWarning.Explanation => @"[original] The extern alias '{0}' was not specified in a /reference option";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0430";
}
