namespace dotnet_error_lookup.Data.Errors;

public class CS3023 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS3023";
    string IErrorOrWarning.Message => @"CLSCompliant attribute has no meaning when applied to return types. Try putting it on the method instead.";
    string IErrorOrWarning.Explanation => @"[original] CLSCompliant attribute has no meaning when applied to return types. Try putting it on the method instead.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs3023";
}
