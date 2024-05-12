namespace dotnet_error_lookup.Data.Errors;

public class CS0625 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0625";
    string IErrorOrWarning.Message => @"'{0}': instance field in types marked with StructLayout(LayoutKind.Explicit) must have a FieldOffset attribute";
    string IErrorOrWarning.Explanation => @"[original] '{0}': instance field in types marked with StructLayout(LayoutKind.Explicit) must have a FieldOffset attribute";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0625";
}
