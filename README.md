# DSMRv5 CRC Validator

CRC Calculator for DSMRv5 telegrams written in C# using .NET 6. It can be used to validate if messages (telegrams) received from a DSMR supporting utilities meter have come accross correctly by comparing the four letter CRC at the end of the telegram with the CRC that will be calculated over the provided telegram content.

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
