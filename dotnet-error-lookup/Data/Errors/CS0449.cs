namespace dotnet_error_lookup.Data.Errors;

public class CS0449 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0449";
    string IErrorOrWarning.Message => @"The 'class', 'struct', 'unmanaged', 'notnull', and 'default' constraints cannot be combined or duplicated, and must be specified first in the constraints list.";
    string IErrorOrWarning.Explanation => @"[original] The 'class', 'struct', 'unmanaged', 'notnull', and 'default' constraints cannot be combined or duplicated, and must be specified first in the constraints list.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0449";
}
