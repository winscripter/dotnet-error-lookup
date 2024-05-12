# dotnet-error-lookup
It's a command-line C# tool to output more information about a C# syntax error or warning.

### Example
```
> dotnet-error-lookup CS0103
Searching for the given error...
We found a syntax diagnostic 'CS0103.'


Type: Error
Message: "The name '{0}' does not exist in the current context"
Documentation Reference: https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs0103
No sample code for this error.
No sample fix documented for this error.

> 
```
