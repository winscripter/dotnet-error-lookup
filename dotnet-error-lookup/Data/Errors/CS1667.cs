namespace dotnet_error_lookup.Data.Errors;

public class CS1667 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1667";
    string IErrorOrWarning.Message => @"Attribute '{0}' is not valid on property or event accessors. It is only valid on '{1}' declarations.";
    string IErrorOrWarning.Explanation => @"[original] Attribute '{0}' is not valid on property or event accessors. It is only valid on '{1}' declarations.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1667";
}
