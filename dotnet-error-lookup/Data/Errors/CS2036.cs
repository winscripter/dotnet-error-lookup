namespace dotnet_error_lookup.Data.Errors;

public class CS2036 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS2036";
    string IErrorOrWarning.Message => @"The /pdb option requires that the /debug option also be used";
    string IErrorOrWarning.Explanation => @"[original] The /pdb option requires that the /debug option also be used";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs2036";
}
