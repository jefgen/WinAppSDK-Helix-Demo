# WinAppSDK-Helix-Demo

This repo is a small demo of how to run TAEF tests inside the Helix environment for the Windows App SDK.

## What is Helix?

Helix is a test execution environment from the .NET Core team. It is a part of the .NET Arcade SDK. It primarily functions or operates as a pool of VM(s). These VMs are part of a set of "queues" that are used to execute work item(s) that are sent to them.

## WinUI.Helix Package

This uses the `Microsoft.Internal.WinUI.Helix` Nuget package from the WinUI/XAML team to run tests in Helix.

The WinUI.Helix package provides additional functionality on top of Helix to make executing tests easier.

(There is some more info on the WinUI Helix package here: https://github.com/microsoft/microsoft-ui-xaml/tree/main/build/Helix)


