namespace dotnet_error_lookup.Data.Errors;

public class CS0078 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS0078";
    string IErrorOrWarning.Message => @"The 'l' suffix is easily confused with the digit '1' -- use 'L' for clarity";
    string IErrorOrWarning.Explanation => @"[original] The 'l' suffix is easily confused with the digit '1' -- use 'L' for clarity";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0078";
}
