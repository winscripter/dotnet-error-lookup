namespace dotnet_error_lookup.Data.Errors;

public class CS3019 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS3019";
    string IErrorOrWarning.Message => @"CLS compliance checking will not be performed on '{0}' because it is not visible from outside this assembly";
    string IErrorOrWarning.Explanation => @"[original] CLS compliance checking will not be performed on '{0}' because it is not visible from outside this assembly";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs3019";
}
