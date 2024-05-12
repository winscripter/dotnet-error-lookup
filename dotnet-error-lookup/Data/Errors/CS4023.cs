namespace dotnet_error_lookup.Data.Errors;

public class CS4023 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS4023";
    string IErrorOrWarning.Message => @"/platform:anycpu32bitpreferred can only be used with /t:exe, /t:winexe and /t:appcontainerexe";
    string IErrorOrWarning.Explanation => @"[original] /platform:anycpu32bitpreferred can only be used with /t:exe, /t:winexe and /t:appcontainerexe";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
