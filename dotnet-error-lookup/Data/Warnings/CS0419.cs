namespace dotnet_error_lookup.Data.Errors;

public class CS0419 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS0419";
    string IErrorOrWarning.Message => @"Ambiguous reference in cref attribute: '{0}'. Assuming '{1}', but could have also matched other overloads including '{2}'.";
    string IErrorOrWarning.Explanation => @"[original] Ambiguous reference in cref attribute: '{0}'. Assuming '{1}', but could have also matched other overloads including '{2}'.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0419";
}
