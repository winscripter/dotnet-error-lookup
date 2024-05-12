namespace dotnet_error_lookup.Data.Errors;

public class CS0455 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0455";
    string IErrorOrWarning.Message => @"Type parameter '{0}' inherits conflicting constraints '{1}' and '{2}'";
    string IErrorOrWarning.Explanation => @"[original] Type parameter '{0}' inherits conflicting constraints '{1}' and '{2}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0455";
}
