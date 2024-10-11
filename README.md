# aepsdk-core-net-ios
.NET MAUI iOS Bindings for Adobe Experience Platform Mobile Core SDK in Swift

Contains the following frameworks:
- AepCore
- AepIdentity
- AepLifecycle
- AepRulesEngine
- AepServices
- AepSignal

## Original library
https://github.com/adobe/aepsdk-core-ios

## Installation
Install the NuGet package Adobe.AepSdk.Core.Net.iOS at https://www.nuget.org/packages/Adobe.AepSdk.Core.Net.iOS.

## Usage
Install the NuGet package for net8.0-ios only. Initialize the SDK and register all extensions on iOS Startup. All methods should be used as indicated in the Adobe Core iOS documentation. There are some included examples of how to initialize the Adobe SDK libraries as part of the AppDelegate's FinishedLaunching in the sample project.