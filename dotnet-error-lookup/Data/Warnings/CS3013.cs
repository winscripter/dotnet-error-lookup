namespace dotnet_error_lookup.Data.Errors;

public class CS3013 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS3013";
    string IErrorOrWarning.Message => @"Added modules must be marked with the CLSCompliant attribute to match the assembly";
    string IErrorOrWarning.Explanation => @"[original] Added modules must be marked with the CLSCompliant attribute to match the assembly";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs3013";
}
