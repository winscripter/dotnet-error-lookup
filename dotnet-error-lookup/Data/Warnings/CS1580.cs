namespace dotnet_error_lookup.Data.Errors;

public class CS1580 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS1580";
    string IErrorOrWarning.Message => @"Invalid type for parameter {0} in XML comment cref attribute: '{1}'";
    string IErrorOrWarning.Explanation => @"[original] Invalid type for parameter {0} in XML comment cref attribute: '{1}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1580";
}
