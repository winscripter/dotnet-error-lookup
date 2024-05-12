namespace dotnet_error_lookup.Data.Errors;

public class CS0611 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0611";
    string IErrorOrWarning.Message => @"Array elements cannot be of type '{0}'";
    string IErrorOrWarning.Explanation => @"[original] Array elements cannot be of type '{0}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0611";
}
