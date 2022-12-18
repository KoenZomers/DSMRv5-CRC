# DSMRv5 CRC Validator

CRC Calculator for DSMRv5 telegrams written in C# using .NET 6. It can be used to validate if messages (telegrams) received from a DSMR supporting utilities meter have come accross correctly by comparing the four letter CRC at the end of the telegram with the CRC that will be calculated over the provided telegram content.

## Usage

This source code contains a library project containing the static class `KoenZomers.Tools.DSMRv5CrcCalculator` which contains these static methods:

1. CalculateChecksum - Generates the CRC checksum over the content of a provided DSMR message
1. DefineChecksum - Returns the CRC checksum as it is stated in the provided DSMR message
1. Validate - Combines the two above and returns a boolean if the provided DSMR message is valid

The solution file also contains a simple test console project which you can use to easily try this code for yourself.

## NuGet Package

Available as a NuGet package:

[KoenZomers.DSMRv5CrcCalculator](https://www.nuget.org/packages/KoenZomers.DSMRv5CrcCalculator)

## Version History

Version 1.0.0.0 - December 18, 2022

- Initial version

## Resources used

[DSMRv5 specifications](https://www.netbeheernederland.nl/_upload/Files/Slimme_meter_15_a727fce1f1.pdf) (in Dutch)

## Special Thanks

Big thanks to the owner of [this repository](https://github.com/jeroen13/p1-smart-meter-crc16) for building a sample using JavaScript which inspired me to build this .NET 6 version.

## Feedback

Comments\suggestions\bug reports are welcome!

Koen Zomers
koen@zomers.eu
