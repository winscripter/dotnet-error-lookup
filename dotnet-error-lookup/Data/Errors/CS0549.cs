namespace dotnet_error_lookup.Data.Errors;

public class CS0549 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0549";
    string IErrorOrWarning.Message => @"'{0}' is a new virtual member in sealed type '{1}'";
    string IErrorOrWarning.Explanation => @"[original] '{0}' is a new virtual member in sealed type '{1}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0549";
}
