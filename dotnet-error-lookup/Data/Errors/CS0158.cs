namespace dotnet_error_lookup.Data.Errors;

public class CS0158 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0158";
    string IErrorOrWarning.Message => @"The label '{0}' shadows another label by the same name in a contained scope";
    string IErrorOrWarning.Explanation => @"[original] The label '{0}' shadows another label by the same name in a contained scope";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0158";
}
