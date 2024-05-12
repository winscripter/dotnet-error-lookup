namespace dotnet_error_lookup.Data.Errors;

public class CS0550 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0550";
    string IErrorOrWarning.Message => @"'{0}' adds an accessor not found in interface member '{1}'";
    string IErrorOrWarning.Explanation => @"[original] '{0}' adds an accessor not found in interface member '{1}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0550";
}
