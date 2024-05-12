namespace dotnet_error_lookup.Data.Errors;

public class CS3012 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS3012";
    string IErrorOrWarning.Message => @"You must specify the CLSCompliant attribute on the assembly, not the module, to enable CLS compliance checking";
    string IErrorOrWarning.Explanation => @"[original] You must specify the CLSCompliant attribute on the assembly, not the module, to enable CLS compliance checking";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs3012";
}
