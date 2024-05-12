namespace dotnet_error_lookup.Data.Errors;

public class CS1613 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1613";
    string IErrorOrWarning.Message => @"The managed coclass wrapper class '{0}' for interface '{1}' cannot be found (are you missing an assembly reference?)";
    string IErrorOrWarning.Explanation => @"[original] The managed coclass wrapper class '{0}' for interface '{1}' cannot be found (are you missing an assembly reference?)";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1613";
}
