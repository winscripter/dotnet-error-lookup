namespace dotnet_error_lookup.Data.Errors;

public class CS0734 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0734";
    string IErrorOrWarning.Message => @"The /moduleassemblyname option may only be specified when building a target type of 'module'";
    string IErrorOrWarning.Explanation => @"[original] The /moduleassemblyname option may only be specified when building a target type of 'module'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0734";
}
