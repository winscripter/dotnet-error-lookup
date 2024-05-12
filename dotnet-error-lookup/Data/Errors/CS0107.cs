namespace dotnet_error_lookup.Data.Errors;

public class CS0107 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0107";
    string IErrorOrWarning.Message => @"More than one protection modifier";
    string IErrorOrWarning.Explanation => @"[original] More than one protection modifier";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0107";
}
