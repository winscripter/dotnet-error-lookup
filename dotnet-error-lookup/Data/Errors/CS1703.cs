namespace dotnet_error_lookup.Data.Errors;

public class CS1703 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1703";
    string IErrorOrWarning.Message => @"Multiple assemblies with equivalent identity have been imported: '{0}' and '{1}'. Remove one of the duplicate references.";
    string IErrorOrWarning.Explanation => @"[original] Multiple assemblies with equivalent identity have been imported: '{0}' and '{1}'. Remove one of the duplicate references.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs1703";
}
