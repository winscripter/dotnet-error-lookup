namespace dotnet_error_lookup.Data.Errors;

public class CS0636 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0636";
    string IErrorOrWarning.Message => @"The FieldOffset attribute can only be placed on members of types marked with the StructLayout(LayoutKind.Explicit)";
    string IErrorOrWarning.Explanation => @"[original] The FieldOffset attribute can only be placed on members of types marked with the StructLayout(LayoutKind.Explicit)";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0636";
}
