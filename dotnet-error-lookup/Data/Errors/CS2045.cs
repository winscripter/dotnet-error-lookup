namespace dotnet_error_lookup.Data.Errors;

public class CS2045 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS2045";
    string IErrorOrWarning.Message => @"/embed switch is only supported when emitting a PDB.";
    string IErrorOrWarning.Explanation => @"[original] /embed switch is only supported when emitting a PDB.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
