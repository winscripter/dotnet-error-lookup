namespace dotnet_error_lookup.Data.Errors;

public class CS0401 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0401";
    string IErrorOrWarning.Message => @"The new() constraint must be the last constraint specified";
    string IErrorOrWarning.Explanation => @"[original] The new() constraint must be the last constraint specified";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0401";
}
