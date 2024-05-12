namespace dotnet_error_lookup.Data.Errors;

public class CS0017 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0017";
    string IErrorOrWarning.Message => @"Program has more than one entry point defined. Compile with /main to specify the type that contains the entry point.";
    string IErrorOrWarning.Explanation => @"[original] Program has more than one entry point defined. Compile with /main to specify the type that contains the entry point.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0017";
}
