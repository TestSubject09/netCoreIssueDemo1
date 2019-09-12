# netCoreIssueDemo1
.net Core issue with the PrivateAssets attribute.

Similar issue with https://github.com/dotnet/cli/issues/7786 but not quite the same.

## Steps to reproduce

Create a project layout like this.

Assembly A -> Assembly B -> Assembly C.

Program lives in Assembly A.
ClassB lives in Assembly B.
ClassC lives in Assembly C.

I don't want AssemblyC to be directly accessible in AssemblyA. So I added PrivateAssets = "All" in the ProjectReference element in the AssemblyB.csproj file.

In ClassC i need to use a NuGet package (lets say Newtonsoft.Json 12.0.2) that is not needed in Assembly A or B.

## Expected  behavior

I should be able to use the JsonConvert class inside Assembly C.

## Actual behavior

At runtime it throws System.IO.FileNotFoundException: Could not load file or assembly 'Newtonsoft.Json'

## Workaround
If I also add the Newtonsoft package to the startup assembly A it works as expected.

I think that adding a nuget reference in one of my projects should not force me to add it in the startup project as well.






