namespace dotnet_error_lookup.Data.Errors;

public class CS0681 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0681";
    string IErrorOrWarning.Message => @"The modifier 'abstract' is not valid on fields. Try using a property instead.";
    string IErrorOrWarning.Explanation => @"[original] The modifier 'abstract' is not valid on fields. Try using a property instead.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0681";
}
