# DotnetMturk

The Amazon Mechanical Turk SDK for .Net is a set of libraries and tools designed to make it easier for you to build solutions leveraging Amazon Mechanical Turk. This repo tracks changes from the official version. Current WDSL schema: 2014-08-15``.

## Source

This is a fork of the .Net SDK v1.6 published on Codeplex under the Apache License v2: http://mturkdotnet.codeplex.com/. We have only included the source. Please refer to the original code drop on codeplex.com for documentation, schemas, tests, and samples.

## Changes

We have made some minor modification for practical reasons. It's easier work on a single assembly in PowerShell. 
Compare the master and vanilla branch for a detailed change log.

- Merged code from `Amazon.WebServices.MechanicalTurk.Domain` to `Amazon.WebServices.MechanicalTurk`. Moved code is now in folder Domain, namespace logic stays intact.
- Dropped documentation and outdated tests.
- Added some convenience overloads for `CreateExternalHIT` and `UpdateQualificationType`
- Updated to [Mturk API version 2014-08-15](http://docs.aws.amazon.com/AWSMechTurk/latest/AWSMturkAPI/ApiReference_WsdlLocationArticle.html). New comparators are included.
- Workaround for GetBonusPayment issue.
- Use Mturk .Net API from PowerShell. See [dotnetmturk.ps1](https://github.com/DeSciL/DotnetMturk/blob/master/DotnetMturk.ps1) for an example and (PsAmt)[https://github.com/DeSciL/PsAmt] for the full PowerShell module.

## License

[Apache v2](https://github.com/DeSciL/DotnetMturk/blob/master/LICENSE)