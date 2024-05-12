namespace dotnet_error_lookup.Data.Errors;

public class CS0281 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0281";
    string IErrorOrWarning.Message => @"Friend access was granted by '{0}', but the public key of the output assembly ('{1}') does not match that specified by the InternalsVisibleTo attribute in the granting assembly.";
    string IErrorOrWarning.Explanation => @"[original] Friend access was granted by '{0}', but the public key of the output assembly ('{1}') does not match that specified by the InternalsVisibleTo attribute in the granting assembly.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0281";
}
