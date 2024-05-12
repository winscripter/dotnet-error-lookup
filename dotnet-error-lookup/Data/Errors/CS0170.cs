namespace dotnet_error_lookup.Data.Errors;

public class CS0170 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0170";
    string IErrorOrWarning.Message => @"Use of possibly unassigned field '{0}'";
    string IErrorOrWarning.Explanation => @"[original] Use of possibly unassigned field '{0}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0170";
}
