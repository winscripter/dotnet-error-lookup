namespace dotnet_error_lookup.Data.Errors;

public class CS0227 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0227";
    string IErrorOrWarning.Message => @"Unsafe code may only appear if compiling with /unsafe";
    string IErrorOrWarning.Explanation => @"[original] Unsafe code may only appear if compiling with /unsafe";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0227";
}
