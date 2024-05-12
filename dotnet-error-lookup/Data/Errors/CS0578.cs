namespace dotnet_error_lookup.Data.Errors;

public class CS0578 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0578";
    string IErrorOrWarning.Message => @"The Conditional attribute is not valid on '{0}' because its return type is not void";
    string IErrorOrWarning.Explanation => @"[original] The Conditional attribute is not valid on '{0}' because its return type is not void";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0578";
}
