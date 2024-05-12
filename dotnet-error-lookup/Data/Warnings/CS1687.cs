namespace dotnet_error_lookup.Data.Errors;

public class CS1687 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS1687";
    string IErrorOrWarning.Message => @"Source file has exceeded the limit of 16,707,565 lines representable in the PDB; debug information will be incorrect";
    string IErrorOrWarning.Explanation => @"[original] Source file has exceeded the limit of 16,707,565 lines representable in the PDB; debug information will be incorrect";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1687";
}
