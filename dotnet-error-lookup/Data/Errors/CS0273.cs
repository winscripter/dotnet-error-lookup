namespace dotnet_error_lookup.Data.Errors;

public class CS0273 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0273";
    string IErrorOrWarning.Message => @"The accessibility modifier of the '{0}' accessor must be more restrictive than the property or indexer '{1}'";
    string IErrorOrWarning.Explanation => @"[original] The accessibility modifier of the '{0}' accessor must be more restrictive than the property or indexer '{1}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0273";
}
