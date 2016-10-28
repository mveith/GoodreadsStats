// include Fake lib
#r "./packages/FAKE/tools/FakeLib.dll"

open Fake

RestorePackages()

// Directories
let buildAppDir = "./build/app/server/"
let appSrcDir = "./GoodreadsStats.Server/"

let key = getBuildParam "key"
let secret = getBuildParam "secret"

let configFilePath = System.IO.Path.Combine [| appSrcDir; "App.config" |]

updateAppSetting "clientKey" key configFilePath
updateAppSetting "clientSecret" secret configFilePath

Target "CleanApp" (fun _ -> CleanDir buildAppDir)
Target "BuildApp" (fun _ -> 
    !!(appSrcDir + "**/*.fsproj")
    |> MSBuildRelease buildAppDir "Build"
    |> Log "AppBuild-Output: ")

// Dependencies
"CleanApp" ==> "BuildApp"

// start build
RunTargetOrDefault "BuildApp"
