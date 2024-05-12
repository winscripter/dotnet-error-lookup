namespace dotnet_error_lookup.Data.Errors;

public class CS1645 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS1645";
    string IErrorOrWarning.Message => @"Feature '{0}' is not part of the standardized ISO C# language specification, and may not be accepted by other compilers";
    string IErrorOrWarning.Explanation => @"[original] Feature '{0}' is not part of the standardized ISO C# language specification, and may not be accepted by other compilers";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1645";
}
