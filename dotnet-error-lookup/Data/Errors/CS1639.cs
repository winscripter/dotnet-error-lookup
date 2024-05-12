namespace dotnet_error_lookup.Data.Errors;

public class CS1639 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1639";
    string IErrorOrWarning.Message => @"The managed coclass wrapper class signature '{0}' for interface '{1}' is not a valid class name signature";
    string IErrorOrWarning.Explanation => @"[original] The managed coclass wrapper class signature '{0}' for interface '{1}' is not a valid class name signature";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1639";
}
