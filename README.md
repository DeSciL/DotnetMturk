# MturkDotNet

The Amazon Mechanical Turk SDK for .Net is a set of libraries and tools designed to make it easier for you to build solutions leveraging Amazon Mechanical Turk. WSDL schema: `2014-08-15`.

## Source

This is a fork of the [Amazon Mechanical Turk SDK for .NET](http://mturkdotnet.codeplex.com/) (v1.6) published on Codeplex under the Apache License v2. This repo tracks our changes from the official version. We have only mirrored sources. Please refer to the original code drop for schemas, tests, and samples.

## Changes

We have made some minor modification for practical reasons. Compare master and vanilla branchs for [details on changes](https://github.com/DeSciL/DotnetMturk/compare/vanilla...master).

- Merged code into single assembly. Moved Amazon.WebServices.MechanicalTurk.Domain to Amazon.WebServices.MechanicalTurk, namespace logic stays intact.
- Dropped documentation and outdated tests.
- Added some convenience overloads for `CreateExternalHIT` and `UpdateQualificationType`
- Updated to [Mturk API version 2014-08-15](http://docs.aws.amazon.com/AWSMechTurk/latest/AWSMturkAPI/ApiReference_WsdlLocationArticle.html). New [comparators](http://mechanicalturk.typepad.com/blog/2014/07/new-qualification-comparators-add-greater-flexibility-to-qualifications-.html) like `In` and `NotIn`are included.
- Workaround for `GetBonusPayments` issue.
- Added `GetRequesterWorkerStatistic'
- Use Mturk .Net API from PowerShell. See [dotnetmturk.ps1](https://github.com/DeSciL/DotnetMturk/blob/master/MturkDotNet.ps1) for an example and [PsAmt](https://github.com/DeSciL/PsAmt) for a PowerShell module.

## License

[Apache v2](https://github.com/DeSciL/DotnetMturk/blob/master/LICENSE)