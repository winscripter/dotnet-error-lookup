namespace dotnet_error_lookup.Data.Errors;

public class CS1608 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1608";
    string IErrorOrWarning.Message => @"The RequiredAttribute attribute is not permitted on C# types";
    string IErrorOrWarning.Explanation => @"[original] The RequiredAttribute attribute is not permitted on C# types";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1608";
}
