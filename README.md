# DotnetMturk

The Amazon Mechanical Turk SDK for .Net is a set of libraries and tools designed to make it easier for you to build solutions leveraging Amazon Mechanical Turk. This repo tracks changes from the official version.

## Source

This is a fork of the .Net SDK v1.6 published on Codeplex under the Apache License v2: http://mturkdotnet.codeplex.com/. We have only included the source. Please refer to the original code drop on codeplex.com for documentation and schemas.

## Changes

We have made some minor modification for practical reasons. It's easier work on a single assembly in PowerShell. 
Compare the master and vanilla branch for a detailed change log.

- Moved code from Amazon.WebServices.MechanicalTurk.Domain to Amazon.WebServices.MechanicalTurk. Moved code is now in folder Domain, namespace logic stays intact.
- Dropped code in project Amazon.WebServices.MechanicalTurk.Domain.
- Dropped tests in project Amazon.WebServices.MechanicalTurk.Test.
- Dropped all documentation.
- Added some convenience overloads
- Minor cleanup
- Updated to latest Mturk API version (2014-08-15)

## License

Apache v2