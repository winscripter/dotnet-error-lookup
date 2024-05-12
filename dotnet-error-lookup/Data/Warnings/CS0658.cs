namespace dotnet_error_lookup.Data.Errors;

public class CS0658 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS0658";
    string IErrorOrWarning.Message => @"'{0}' is not a recognized attribute location. Valid attribute locations for this declaration are '{1}'. All attributes in this block will be ignored.";
    string IErrorOrWarning.Explanation => @"[original] '{0}' is not a recognized attribute location. Valid attribute locations for this declaration are '{1}'. All attributes in this block will be ignored.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0658";
}
