namespace dotnet_error_lookup.Data.Errors;

public class CS0582 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0582";
    string IErrorOrWarning.Message => @"The Conditional attribute is not valid on interface members";
    string IErrorOrWarning.Explanation => @"[original] The Conditional attribute is not valid on interface members";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0582";
}
