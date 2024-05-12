namespace dotnet_error_lookup.Data.Errors;

public class CS0210 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0210";
    string IErrorOrWarning.Message => @"You must provide an initializer in a fixed or using statement declaration";
    string IErrorOrWarning.Explanation => @"[original] You must provide an initializer in a fixed or using statement declaration";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0210";
}
