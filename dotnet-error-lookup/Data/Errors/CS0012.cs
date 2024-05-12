namespace dotnet_error_lookup.Data.Errors;

public class CS0012 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0012";
    string IErrorOrWarning.Message => @"The type '{0}' is defined in an assembly that is not referenced. You must add a reference to assembly '{1}'.";
    string IErrorOrWarning.Explanation => @"[original] The type '{0}' is defined in an assembly that is not referenced. You must add a reference to assembly '{1}'.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0012";
}
