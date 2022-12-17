Console.WriteLine("DSMRv5 CRC Validator by Koen Zomers");
Console.WriteLine();

var testMessages = new[]
{
    "/CTA5ZIV-METER\r\n\r\n1-3:0.2.8(50)\r\n0-0:1.0.0(221217223038W)\r\n0-0:96.1.1(4530303639303030373030000000000000)\r\n1-0:1.8.1(018762.479*kWh)\r\n1-0:1.8.2(004578.328*kWh)\r\n1-0:2.8.1(004852.514*kWh)\r\n1-0:2.8.2(011256.822*kWh)\r\n0-0:96.14.0(0001)\r\n1-0:1.7.0(00.626*kW)\r\n1-0:2.7.0(00.000*kW)\r\n0-0:96.7.21(00056)\r\n0-0:96.7.9(00119)\r\n1-0:99.97.0(10)(0-0:96.7.19)(221215021710W)(0002096130*s)(221215021709W)(0002096130*s)(221215021709W)(0002096130*s)(221120054539W)(0016346199*s)(221120054539W)(0016346199*s)(221120054539W)(0016346198*s)(221026101410S)(0014198710*s)(221026101410S)(0014198709*s)(221026101409S)(0014198709*s)(221001134240S)(0012051219*s)\r\n1-0:32.32.0(00023)\r\n1-0:52.32.0(00025)\r\n1-0:72.32.0(00019)\r\n1-0:32.36.0(00019)\r\n1-0:52.36.0(00019)\r\n1-0:72.36.0(00019)\r\n0-0:96.13.0()\r\n1-0:32.7.0(228.0*V)\r\n1-0:52.7.0(227.0*V)\r\n1-0:72.7.0(229.0*V)\r\n1-0:31.7.0(001*A)\r\n1-0:51.7.0(001*A)\r\n1-0:71.7.0(001*A)\r\n1-0:21.7.0(00.177*kW)\r\n1-0:41.7.0(00.168*kW)\r\n1-0:61.7.0(00.272*kW)\r\n1-0:22.7.0(00.000*kW)\r\n1-0:42.7.0(00.000*kW)\r\n1-0:62.7.0(00.000*kW)\r\n0-1:24.1.0(003)\r\n0-1:96.1.0(4730303732303033393532393230313139)\r\n0-1:24.2.1(221217223000W)(01208.731*m3)\r\n!FE85",
    "/CTA5ZIV-METER\r\n\r\n1-3:0.2.8(50)\r\n0-0:1.0.0(221217234030W)\r\n0-0:96.1.1(4530303639303030373030000000000000)\r\n1-0:1.8.1(018763.136*kWh)\r\n1-0:1.8.2(004578.328*kWh)\r\n1-0:2.8.1(004852.514*kWh)\r\n1-0:2.8.2(011256.822*kWh)\r\n0-0:96.14.0(0001)\r\n1-0:1.7.0(00.679*kW)\r\n1-0:2.7.0(00.000*kW)\r\n0-0:96.7.21(00056)\r\n0-0:96.7.9(00119)\r\n1-0:99.97.0(10)(0-0:96.7.19)(221215021710W)(0002096130*s)(221215021709W)(0002096130*s)(221215021709W)(0002096130*s)(221120054539W)(0016346199*s)(221120054539W)(0016346199*s)(221120054539W)(0016346198*s)(221026101410S)(0014198710*s)(221026101410S)(0014198709*s)(221026101409S)(0014198709*s)(221001134240S)(0012051219*s)\r\n1-0:32.32.0(00023)\r\n1-0:52.32.0(00025)\r\n1-0:72.32.0(00019)\r\n1-0:32.36.0(00019)\r\n1-0:52.36.0(00019)\r\n1-0:72.36.0(00019)\r\n0-0:96.13.0()\r\n1-0:32.7.0(231.0*V)\r\n1-0:52.7.0(230.0*V)\r\n1-0:72.7.0(232.0*V)\r\n1-0:31.7.0(001*A)\r\n1-0:51.7.0(001*A)\r\n1-0:71.7.0(002*A)\r\n1-0:21.7.0(00.176*kW)\r\n1-0:41.7.0(00.157*kW)\r\n1-0:61.7.0(00.344*kW)\r\n1-0:22.7.0(00.000*kW)\r\n1-0:42.7.0(00.000*kW)\r\n1-0:62.7.0(00.000*kW)\r\n0-1:24.1.0(003)\r\n0-1:96.1.0(4730303732303033393532393230313139)\r\n0-1:24.2.1(221217234000W)(01208.731*m3)\r\n!274B"
};

// Retrieve checksums included in the test messages
Console.WriteLine("Retrieving checksums from DSMR test messages");
foreach (var testMessage in testMessages.Select((Value, Index) => (Value, Index)))
{
    Console.WriteLine($"- Message #{testMessage.Index}: {KoenZomers.Tools.DSMRv5CrcCalculator.DefineChecksum(testMessage.Value)}");
}
Console.WriteLine();

// Calculate checksums over the content of the test messages
Console.WriteLine("Calculating checksums over the DSMR test message content");
foreach (var testMessage in testMessages.Select((Value, Index) => (Value, Index)))
{
    Console.WriteLine($"- Message #{testMessage.Index}: {KoenZomers.Tools.DSMRv5CrcCalculator.CalculateChecksum(testMessage.Value)}");
}
Console.WriteLine();

// Validate i the checksums in the test messages matches the checksum we calculate ourself over the content
Console.WriteLine("Validating DSMR test messages");
foreach (var testMessage in testMessages.Select((Value, Index) => (Value, Index)))
{
    Console.WriteLine($"- Message #{testMessage.Index}: {KoenZomers.Tools.DSMRv5CrcCalculator.Validate(testMessage.Value)}");
}
Console.ReadKey();