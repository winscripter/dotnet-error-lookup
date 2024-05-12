namespace dotnet_error_lookup.Data.Errors;

public class CS1678 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1678";
    string IErrorOrWarning.Message => @"Parameter {0} is declared as type '{1}{2}' but should be '{3}{4}'";
    string IErrorOrWarning.Explanation => @"[original] Parameter {0} is declared as type '{1}{2}' but should be '{3}{4}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1678";
}
