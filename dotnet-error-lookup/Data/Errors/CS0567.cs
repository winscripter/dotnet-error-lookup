namespace dotnet_error_lookup.Data.Errors;

public class CS0567 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0567";
    string IErrorOrWarning.Message => @"Conversion, equality, or inequality operators declared in interfaces must be abstract or virtual";
    string IErrorOrWarning.Explanation => @"[original] Conversion, equality, or inequality operators declared in interfaces must be abstract or virtual";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0567";
}
