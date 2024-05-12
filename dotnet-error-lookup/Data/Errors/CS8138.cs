namespace dotnet_error_lookup.Data.Errors;

public class CS8138 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8138";
    string IErrorOrWarning.Message => @"Cannot reference 'System.Runtime.CompilerServices.TupleElementNamesAttribute' explicitly. Use the tuple syntax to define tuple names.";
    string IErrorOrWarning.Explanation => @"[original] Cannot reference 'System.Runtime.CompilerServices.TupleElementNamesAttribute' explicitly. Use the tuple syntax to define tuple names.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
