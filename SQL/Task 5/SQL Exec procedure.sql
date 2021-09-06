DECLARE @FileXML XML = '<?xml version="1.0"?>
 <Results>
   <Providers>
     <ProviderID>ab43a726-b382-4bcd-9e6b-a6d6f706b77b</ProviderID>
     <Name>Tarun1</Name>
     <PhoneNumber>123456789</PhoneNumber>
     <Address>Ukraine</Address>
   </Providers>
   <Providers>
     <ProviderID>aaf84042-111b-4e4d-b6f2-3b781950c757</ProviderID>
     <Name>Tarun2</Name>
     <PhoneNumber>123456789</PhoneNumber>
     <Address>USA</Address>
   </Providers>
   <Providers>
     <ProviderID>edd0ebaf-8910-480e-ae21-c0f483af6708</ProviderID>
     <Name>Tarun3</Name>
     <PhoneNumber>123456789</PhoneNumber>
     <Address>Netherlands</Address>
   </Providers>
 </Results>'
 
 EXEC InsertToTableFromXML @FileXML;