namespace dotnet_error_lookup.Data.Errors;

public class CS0672 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS0672";
    string IErrorOrWarning.Message => @"Member '{0}' overrides obsolete member '{1}'. Add the Obsolete attribute to '{0}'.";
    string IErrorOrWarning.Explanation => @"[original] Member '{0}' overrides obsolete member '{1}'. Add the Obsolete attribute to '{0}'.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0672";
}
