namespace dotnet_error_lookup.Data.Errors;

public class CS0470 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0470";
    string IErrorOrWarning.Message => @"Method '{0}' cannot implement interface accessor '{1}' for type '{2}'. Use an explicit interface implementation.";
    string IErrorOrWarning.Explanation => @"[original] Method '{0}' cannot implement interface accessor '{1}' for type '{2}'. Use an explicit interface implementation.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0470";
}
