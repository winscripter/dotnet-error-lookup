namespace dotnet_error_lookup.Data.Errors;

public class CS2044 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS2044";
    string IErrorOrWarning.Message => @"/sourcelink switch is only supported when emitting PDB.";
    string IErrorOrWarning.Explanation => @"[original] /sourcelink switch is only supported when emitting PDB.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
