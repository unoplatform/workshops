// Install modules
#module nuget:?package=Cake.DotNetTool.Module&version=0.3.0

// Install addins.
#addin "nuget:https://api.nuget.org/v3/index.json?package=Cake.Npm&version=0.17.0"

// Install .NET Core Global tools.
#tool "dotnet:https://api.nuget.org/v3/index.json?package=dotnet-format&version=3.1.37601"
#tool "dotnet:https://api.nuget.org/v3/index.json?package=GitVersion.Tool&version=4.0.1-beta1-58"

var target = Argument("target", "Default");

var solutions = new List<FilePath>() {
    new FilePath(@"mastering-uno\solution\TodoApp.sln")
};

Setup(context =>
{
    Information("Installing npm dependencies");
    NpmInstall();
});

Teardown(context =>
{
    Information("Starting Teardown...");

    if(context.Successful)
    {
        // todo
    }

    Information("Finished running tasks.");
});

//////////////////////////////////////////////////////////////////////
// TASKS
//////////////////////////////////////////////////////////////////////

Task("Clean")
    .Does(() =>
    {

    });

Task("LintMarkdown")
    .Does(() =>
    {
        var exitCode = StartProcess(@"node_modules\.bin\markdownlint.cmd", "--ignore node_modules .");

        if (BuildSystem.IsPullRequest)
        {
            if (exitCode > 0)
            {
                throw new Exception(string.Format("Terminating build due to linting errors. Markdown must pass the linter before pull-requests can be merged.", exitCode));
            }
        }
    });

Task("FormatCode")
    .Does(() =>
    {
        foreach (var solution in solutions)
        {
            var exitCode = StartProcess("dotnet", $"format --check --workspace {solution.FullPath}");

            if (BuildSystem.IsPullRequest)
            {
                if (exitCode > 0)
                {
                    throw new Exception(string.Format("Terminating build because files were formatted. Code must be formatted before pull-requests can be merged.", exitCode));
                }
            }
        }
    });

Task("Restore-NuGet-Packages")
    .IsDependentOn("Clean")
    .Does(() =>
    {
        foreach (var solution in solutions)
        {
            NuGetRestore(solution.FullPath);
        }
    });

Task("Build")
    .IsDependentOn("Format")
    .IsDependentOn("Restore-NuGet-Packages")
    .Does(() =>
    {
        foreach (var solution in solutions)
        {
            MSBuild(solution.FullPath);
            
            // MSBuild(solution.FullPath, new MSBuildSettings()
            //     .WithProperty("AppxBundle", "Always")
            //     .WithProperty("AppxBundlePlatforms", "x86|arm")
            // );
        }
    });

Task("Publish")
    .IsDependentOn("Build")
    .Does(() =>
    {
    });

//////////////////////////////////////////////////////////////////////
// TASK TARGETS
//////////////////////////////////////////////////////////////////////

Task("Format")
    .IsDependentOn("LintMarkdown")
    .IsDependentOn("FormatCode");

Task("Default")
    .IsDependentOn("Build");

//////////////////////////////////////////////////////////////////////
// EXECUTION
//////////////////////////////////////////////////////////////////////

RunTarget(target);
