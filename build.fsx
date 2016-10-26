// include Fake lib
#r @"./packages/FAKE/tools/FakeLib.dll"

open Fake
open System.IO

RestorePackages()

// Directories
let buildAppDir = "./build/app/server/"
let appSrcDir = "./GoodreadsStats.Server/"

Target "CleanApp" (fun _ -> CleanDir buildAppDir)

Target "BuildApp" (fun _ -> 
    !!(appSrcDir + "**/*.fsproj")
    |> MSBuildRelease buildAppDir "Build"
    |> Log "AppBuild-Output: ")

// Dependencies
"CleanApp" ==> "BuildApp"

// start build
RunTargetOrDefault "BuildApp"
