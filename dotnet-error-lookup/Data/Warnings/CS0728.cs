namespace dotnet_error_lookup.Data.Errors;

public class CS0728 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS0728";
    string IErrorOrWarning.Message => @"Possibly incorrect assignment to local '{0}' which is the argument to a using or lock statement. The Dispose call or unlocking will happen on the original value of the local.";
    string IErrorOrWarning.Explanation => @"[original] Possibly incorrect assignment to local '{0}' which is the argument to a using or lock statement. The Dispose call or unlocking will happen on the original value of the local.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0728";
}
