namespace dotnet_error_lookup.Data.Errors;

public class CS1750 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1750";
    string IErrorOrWarning.Message => @"A value of type '{0}' cannot be used as a default parameter because there are no standard conversions to type '{1}'";
    string IErrorOrWarning.Explanation => @"[original] A value of type '{0}' cannot be used as a default parameter because there are no standard conversions to type '{1}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs1750";
}
