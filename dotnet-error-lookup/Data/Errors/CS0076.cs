namespace dotnet_error_lookup.Data.Errors;

public class CS0076 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0076";
    string IErrorOrWarning.Message => @"The enumerator name '{0}' is reserved and cannot be used";
    string IErrorOrWarning.Explanation => @"[original] The enumerator name '{0}' is reserved and cannot be used";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0076";
}
