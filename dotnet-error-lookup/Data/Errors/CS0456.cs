namespace dotnet_error_lookup.Data.Errors;

public class CS0456 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0456";
    string IErrorOrWarning.Message => @"Type parameter '{1}' has the 'struct' constraint so '{1}' cannot be used as a constraint for '{0}'";
    string IErrorOrWarning.Explanation => @"[original] Type parameter '{1}' has the 'struct' constraint so '{1}' cannot be used as a constraint for '{0}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0456";
}
