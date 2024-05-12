namespace dotnet_error_lookup.Data.Errors;

public class CS8670 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS8670";
    string IErrorOrWarning.Message => @"Object or collection initializer implicitly dereferences possibly null member '{0}'.";
    string IErrorOrWarning.Explanation => @"[original] Object or collection initializer implicitly dereferences possibly null member '{0}'.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/nullable-warnings";
}
