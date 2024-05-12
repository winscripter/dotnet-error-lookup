namespace dotnet_error_lookup.Data.Errors;

public class CS3017 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS3017";
    string IErrorOrWarning.Message => @"You cannot specify the CLSCompliant attribute on a module that differs from the CLSCompliant attribute on the assembly";
    string IErrorOrWarning.Explanation => @"[original] You cannot specify the CLSCompliant attribute on a module that differs from the CLSCompliant attribute on the assembly";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs3017";
}
