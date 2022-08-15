using Serilog;

namespace Project.Package
{
    public class MyClass
    {
        //TODO: Update Package settings in Project Properties ->Package tab (or csproj)
        //  Product:  if different than project name
        //  Authors: names of authors
        //  Description: "what's in it for me" description - answer to why devs would use this package
        //  Project URL: Readme file in your Azure DevOps git repo
        //  Repository URL: Azure DevOps git repo
        //  Tags: add any you think might be worthwhile
        public static void WriteSomething(string something)
        {
            Log.Information(something);
        }
    }
}
