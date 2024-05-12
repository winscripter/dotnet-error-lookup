namespace dotnet_error_lookup.Data.Errors;

public class CS8029 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS8029";
    string IErrorOrWarning.Message => @"Local name '{0}' is too long for PDB.  Consider shortening or compiling without /debug.";
    string IErrorOrWarning.Explanation => @"[original] Local name '{0}' is too long for PDB.  Consider shortening or compiling without /debug.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
