// include Fake lib
#r "./packages/FAKE/tools/FakeLib.dll"

open Fake
open Fake.NpmHelper
open System.IO

RestorePackages()

// Directories
let buildAppDir = "./build/app/"
let buildServerDir = Path.Combine [| buildAppDir; "server" |]
let buildClientDir = Path.Combine [| buildAppDir; "client" |]

let serverSrcDir = "./GoodreadsStats.Server/"
let clientSrcDir = "./GoodreadsStats.Client/"

let key = getBuildParam "key"
let secret = getBuildParam "secret"

let configFilePath = Path.Combine [| serverSrcDir; "App.config" |]

updateAppSetting "clientKey" key configFilePath
updateAppSetting "clientSecret" secret configFilePath

let buildServer() = 
    !!(serverSrcDir + "**/*.fsproj")
    |> MSBuildRelease buildServerDir "Build"
    |> Log "AppBuild-Output: "

let buildClient() = 
    Npm(fun p -> 
        { p with Command = Install Standard
                 WorkingDirectory = clientSrcDir })
    Npm(fun p -> 
        { p with Command = (Run "build")
                 WorkingDirectory = clientSrcDir })

    CopyDir buildClientDir clientSrcDir (fun fileName -> not (fileName.EndsWith ".fsx") && not (fileName.EndsWith ".json"))

Target "CleanApp" (fun _ -> CleanDir buildAppDir)
Target "BuildApp" (fun _ -> 
    buildServer()
    buildClient())

// Dependencies
"CleanApp" ==> "BuildApp"
// start build
RunTargetOrDefault "BuildApp"
