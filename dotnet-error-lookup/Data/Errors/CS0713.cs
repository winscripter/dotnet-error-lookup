namespace dotnet_error_lookup.Data.Errors;

public class CS0713 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0713";
    string IErrorOrWarning.Message => @"Static class '{0}' cannot derive from type '{1}'. Static classes must derive from object.";
    string IErrorOrWarning.Explanation => @"[original] Static class '{0}' cannot derive from type '{1}'. Static classes must derive from object.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0713";
}
