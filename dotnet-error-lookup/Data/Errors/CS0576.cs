namespace dotnet_error_lookup.Data.Errors;

public class CS0576 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0576";
    string IErrorOrWarning.Message => @"Namespace '{1}' contains a definition conflicting with alias '{0}'";
    string IErrorOrWarning.Explanation => @"[original] Namespace '{1}' contains a definition conflicting with alias '{0}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0576";
}
