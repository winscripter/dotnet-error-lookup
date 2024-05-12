namespace dotnet_error_lookup.Data.Errors;

public class CS1760 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1760";
    string IErrorOrWarning.Message => @"Assemblies '{0}' and '{1}' refer to the same metadata but only one is a linked reference (specified using /link option); consider removing one of the references.";
    string IErrorOrWarning.Explanation => @"[original] Assemblies '{0}' and '{1}' refer to the same metadata but only one is a linked reference (specified using /link option); consider removing one of the references.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
