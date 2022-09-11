﻿using SOE.Core;
using SOE.Interfaces;
using SOE;
using Gateway.Login;

namespace Gateway.MapChat
{
    internal class Map
    {
        public static void SendPacketPointOfInterestDefinitionReply(SOEClient soeClient)
        {
            //TODO
            LoginManager.SendTunneledClientPacket(soeClient, LoginManager.StringToByteArray(/* PacketPointOfInterestDefinitionReply */ "3900872900000103000000790F00001901000062904D4260E5F741F893B5430456BE3F41050000070000007DD705008B02000000000000643403000B00000073616372656467726F76653C0000000104000000DC4600001A010000B4184AC4643BA8C13FF9CB44295C0F3E41050000070000007DD705008B02000000000000653403000B00000073616372656467726F76655A0000000105000000AB0D00001B0100005AD4B0C44A0CDDC193C8AF43D9CE0F4041050000070000007DD705008B02000000000000663403000B00000073616372656467726F7665140000000106000000C38B0600F66103007764C6C4778131C236F508C4ED0D5EBE41050000070000007DD705008B02000000000000450200000B00000073616372656467726F76651E0000000107000000DE4600001D010000B80EEEC4F6281FC273A8CE437593183F41050000070000007DD705000000000000000000673403000B00000073616372656467726F76650A0000000108000000AE0D00001C2C00004260953FE9262442B05E8B442B871E4041050000070000007DD705008B02000000000000683403000B00000073616372656467726F7665550000000109000000D34900001D2C0000EE7C37C4A4701141467E6C446F122BC041050000070000007DD705008B02000000000000693403000B00000073616372656467726F76653C000000010A000000BD0F00001E2C0000B0F231424260F7C1CB492F45894160BF41050000070000007DD705008B020000000000006A3403000B00000073616372656467726F76655F000000010B0000000D080000840200000000B2420000284200007F44000020407A1D0000060000007DD705000000000000000000860200000B00000073616372656467726F766500000000010C000000B10D0000202C000087D68CC2F0271B421F95DEC3A69B243F41050000070000007DD705008B020000000000006B3403000B00000073616372656467726F76652D000000010D000000AD0D0000212C0000713D1FC4C3F51441AE3382C40AD7034041050000070000007DD705008B020000000000006C3403000B00000073616372656467726F766528000000010E0000004C110000222C0000316493C419840BC2E335D9C32FDDC43F41050000070000007DD705008B020000000000006D3403000B00000073616372656467726F766523000000010F000000B1A10000232C00004ACC04C55839BFC1423092C3FED4D83F41050000070000007DD705008B020000000000006E3403000B00000073616372656467726F76651E0000000110000000AC0D0000A144000039CC05C5C1CA03C2F6308244A245363F41050000070000007DD705008B020000000000006F3403000B00000073616372656467726F766550000000011100000023950100051003004A3CDEC3D7A378C0AC3C3A436DE79BBF41050000070000007DD705008B02000000000000051003000B00000073616372656467726F766537000000011200000015950100061003005E129EC4022B44C2FC394444E3A59BBE41050000070000007DD705008B02000000000000713403000B00000073616372656467726F76653C0000000114000000F85800006F02000091ED8FC2D7A3304166666243D9CEC73F831D0000060000008ED705000000000010070000723403000B00000073616372656467726F76650000000001150000005BD7050070020000A09A6B42DBF9EE4181D5ACC33D0AD73E831D0000060000008FD70500000000000F070000733403000B00000073616372656467726F76650000000001160000005CD7050071020000E15A47C41F85A74037916A44A4703540831D00000600000090D705000000000011070000743403000B00000073616372656467726F76650000000001170000005DD70500720200005C1707C514AEFFC1F6E8B9431904E6BF831D00000600000091D70500000000000E070000753403000B00000073616372656467726F76650000000001180000005E1C0000730200002148BAC42D320CC21098CC438FC2753E831D00000600000092D70500000000000D070000763403000B00000073616372656467726F7665000000000119000000D61B000074020000773631C4B4C833C293520145C52070BF831D00000600000093D705000000000012070000773403000B00000073616372656467726F766500000000011C00000063D7050077020000A4F0E0C3B6F3D2412DB211C16210C83F891D00000600000096D7050000000000000000007A3403000B00000073616372656467726F766500000000011E000000C6120000790200000A87CB43B0723C424CC7AC438B6C97BF891D00000600000098D7050000000000000000007C3403000B00000073616372656467726F766500000000011F0000001E470000090A000029BA0DC531AB82C18F5C1244DB8AADBF0E000000060000007DD7050000000000090700007D3403000B00000073616372656467726F7665000000000120000000160E0000B6170300EAE664C4FD871CC245779644EE3D3C3F0E000000060000007DD70500000000000B0700007E3403000B00000073616372656467726F766500000000012100000087D70500713D00005C0C69C35AD8973F62BE49C29014C13F0E000000060000007DD70500000000000A0700007F3403000B00000073616372656467726F766500000000012200000088D70500B9170300B8E488C346516BC288FCF344D8810F400E000000060000007DD70500000000000C070000803403000B00000073616372656467726F76650000000001230000009ED705007A0200008F4A25C4E3A58DC2F2D40D456210C83F9E1D0000060000007DD705000000000017070000813403000B00000073616372656467726F76650000000001240000009FD705007B020000E3159FC4BA4964C156EE914317D936C09B1D0000060000007DD705000000000015070000823403000B00000073616372656467726F7665000000000125000000A1D705007C02000071BD8F43F628C7410E7DB043986E12C0A41D0000060000007DD705000000000016070000833403000B00000073616372656467726F7665000000000126000000A2D705007D020000EE6801C5E3255DC2E9665243F0A73E40A11D0000060000007DD705000000000014070000843403000B00000073616372656467726F7665000000000127000000D7200600F12D03001CFC09424F1E6CC1549E94C43F915F3F0E000000060000007DD705000000000058070000853403000B00000073616372656467726F7665000000000128000000A5D705009622000040E33CC462BEBCBB15335244685B02C01F050000060000007DD705000000000007070000863403000B00000073616372656467726F7665000000000129000000A5D705006E0F030029DF3A4248671E42C1EB8D446BD42BC01F050000060000007DD705000000000007070000873403000B00000073616372656467726F766500000000012A000000A5D70500470F03000EAF06C5D91C62C2E05B6543FC1842401F050000060000007DD705000000000007070000883403000B00000073616372656467726F766500000000012B000000A5D705000511030061A2DFC35FEF56C06F0396C45B7CBABE1F050000060000007DD705000000000007070000893403000B00000073616372656467726F766500000000012C000000A5D70500770F03007314B94267FEFC41BE3DE9C3B1F9B8BC1F050000060000007DD7050000000000070700008A3403000B00000073616372656467726F766500000000012D000000A5D70500191003003F8489C4BBC41FC249A5E7C304A9983F1F050000060000007DD7050000000000070700008B3403000B00000073616372656467726F766500000000012E000000A5D705007F0F030059AEA9C355DB9D3E00D726C44BCDBEBF1F050000060000007DD7050000000000070700008C3403000B00000073616372656467726F766500000000012F000000A5D70500820F03001CADEBC3A7711D4199204444BB5FC33F1F050000060000007DD7050000000000070700008D3403000B00000073616372656467726F7665000000000130000000A5D70500860F03000A1702C552F200C2E05F88446473DF3F1F050000060000007DD7050000000000070700008E3403000B00000073616372656467726F7665000000000131000000A5D70500161003000F5FAFC4463403C29A4312448A3DA63F1F050000060000007DD7050000000000070700008F3403000B00000073616372656467726F7665000000000132000000A5D705001913030067D288C48723AF40446ECF43DF520E3F1F050000060000007DD705000000000007070000903403000B00000073616372656467726F7665000000000133000000A5D70500861603005868F341BFE87542067B9944A818DFBF1F050000060000007DD705000000000007070000913403000B00000073616372656467726F7665000000000134000000E10800009D030000EBB845C4A9608FC272910645FAEDAFBFC22E0000030000007DD705000000000000000000923403000B00000073616372656467726F7665000000000135000000C50C0000A60300005E4884430B234B42EFE9294320B59DBFC22E0000030000007DD705000000000000000000933403000B00000073616372656467726F7665000000000136000000341400006A040000125FD4C4022BA3C0E5980FC400000000C22E0000030000007DD705000000000000000000943403000B00000073616372656467726F7665000000000137000000751500006D040000718BD1C3D2699641551976C37C61F2BDC22E0000030000007DD705000000000000000000953403000B00000073616372656467726F7665000000000138000000C45200007A420000085861C405D747C2987DE544CF4A163FC22E0000030000007DD705000000000000000000963403000B00000073616372656467726F766500000000013900000085100000DF0400000CAAD243D117A94233C820440F4501BCC22E0000030000007DD705000000000000000000973403000B00000073616372656467726F766500000000013A00000038190000EB050000B248F843B5493C42C88CB24338BE0CC0C22E0000030000007DD705000000000000000000983403000B00000073616372656467726F766500000000013B000000421600005F060000C2A2B942C4AC844257B70A44D07E3CC0C22E0000030000007DD705000000000000000000993403000B00000073616372656467726F766500000000013C0000004116000060060000136206C4BB50D041941D414428613EBFC22E0000030000007DD7050000000000000000009A3403000B00000073616372656467726F766500000000013D00000043160000EA07000089FEF443DF293D42A2D488434703B4BFC22E0000030000007DD7050000000000000000009B3403000B00000073616372656467726F766500000000013E00000046160000F70700009EB5B4C4A65E19C2B79147425E9DD7BFC22E0000030000007DD7050000000000000000009C3403000B00000073616372656467726F766500000000013F00000047160000F8070000F30B64C488A37EC28C8DC743FCA989BFC22E0000030000007DD7050000000000000000009D3403000B00000073616372656467726F76650000000001400000004F160000F90700008F32B3C414AE5BC1140E62C446B62B40C22E0000030000007DD7050000000000000000009E3403000B00000073616372656467726F76650000000001410000004C160000FB07000015C5D8C3A7CBE2BD0931A84456821BC0C22E0000030000007DD7050000000000000000009F3403000B00000073616372656467726F76650000000001420000004B160000FC0700002B351FC296438BBB77823545D8F52940C22E0000030000007DD705000000000000000000A03403000B00000073616372656467726F76650000000001430000004A160000FD0700005D8708C4AC331CC200FF2145147916C0C22E0000030000007DD705000000000000000000A13403000B00000073616372656467726F76650000000001440000004E160000FE0700009B6508C57C2D12C2B9130D438DB4E4BEC22E0000030000007DD705000000000000000000A23403000B00000073616372656467726F766500000000014500000049160000FF07000034205FC353D06240332349C48DD310BFC22E0000030000007DD705000000000000000000A33403000B00000073616372656467726F766500000000014600000048160000000800002D31E7C245DCA7411D3E484426A7AABFC22E0000030000007DD705000000000000000000A43403000B00000073616372656467726F7665000000000147000000D613000080270000ACDCCBC35CB95BC251160345AF5D763FC22E0000030000007DD705000000000000000000A53403000B00000073616372656467726F76650000000001480000002B470000E9230000E9E89FC38A19CCC24C1D224588D98BBDC22E0000030000007DD705000000000000000000A63403000B00000073616372656467726F76650000000001490000005819000035090000B0AFC1431AD9EB426C6687C143E725BFC22E0000030000007DD705000000000000000000A73403000B00000073616372656467726F766500000000014A000000751100003C090000E04122C4E9194BC232AF1C4599820D40C22E0000030000007DD705000000000000000000A83403000B00000073616372656467726F766500000000014B0000005B1000003D090000205687C2ECAFF2C19D9C1045B6D607C0C22E0000030000007DD705000000000000000000A93403000B00000073616372656467726F766500000000014C000000451600003E09000092F6C0C3851288C2D8F9E94456493B40C22E0000030000007DD705000000000000000000AA3403000B00000073616372656467726F766500000000014D000000DF4600003F0900002BB354C45BB676C21F3310458577C9BFC22E0000030000007DD705000000000000000000AB3403000B00000073616372656467726F766500000000014E0000000D14000093090000A73232C4DA5047C2FB10DB448BDE65BFC22E0000030000007DD705000000000000000000AC3403000B00000073616372656467726F766500000000014F000000A2000000D20B00001A182AC4BFEE3042402ABA44645D1440C22E0000030000007DD705000000000000000000AD3403000B00000073616372656467726F7665000000000150000000111E00002816000085DE61C465793FC253566F4365C748C0C22E0000030000007DD705000000000000000000AE3403000B00000073616372656467726F766500000000015200000059180100E436000089E71143F5C31742B2FCEAC361323940C22E0000030000007DD705000000000000000000B03403000B00000073616372656467726F76650000000001530000005A180100E5360000F2EA48C442604DC277A629C4068155BFC22E0000030000007DD705000000000000000000B13403000B00000073616372656467726F76650000000001540000000E180100E7360000F5B334C2A464F8C1658392C4EB909B3CC22E0000030000007DD705000000000000000000B23403000B00000073616372656467726F76650000000001550000005B180100E83600002DBB0DC58CC4EAC1090160441F4B29C0C22E0000030000007DD705000000000000000000B33403000B00000073616372656467726F7665000000000156000000035C0000E93600007E23B4C32E2AA6C2EB3A16451FBA383FC22E0000030000007DD705000000000000000000B43403000B00000073616372656467726F76650000000001570000005C180100EE360000DC2004C5552D64C270BB8B43570916BDC22E0000030000007DD705000000000000000000B53403000B00000073616372656467726F7665000000000158000000441600008647000028BF21C587E198C10C0680443815FDBFC22E0000030000007DD705000000000000000000B63403000B00000073616372656467726F76650000000001590000007A8E0100874E000029CADFC330F02CBF4601A34372A732C0C22E0000030000007DD705000000000000000000B73403000B00000073616372656467726F766500000000015A0000005D180100780E03008B951E4391E332421360864441F21940C22E0000030000007DD705000000000000000000B83403000B00000073616372656467726F766500000000015D000000830C000098290300F01705C49C0485C2FA980A45AE47913F41050000070000007DD705008B02000000000000BB3403000B00000073616372656467726F76655F000000015E0000000D08000037200000453FE8C39B7E1741BA384144E0D6FD3E7A1D0000060000007DD705000000000013070000BC3403000B00000073616372656467726F766500000000015F0000000D0800007A2200001B909BC4A6C464C1B568CA43C76825407A1D0000060000007DD705000000000013070000BD3403000B00000073616372656467726F76650000000001600000000D0800007C2200006ACA4BC4B7F1ED3FA3355244882BBFBF7A1D0000060000007DD705000000000013070000BE3403000B00000073616372656467726F76650000000001610000000D0800007D2200008AC3F3C43FDD1FC2725717C4EC349A3E7A1D0000060000007DD705000000000013070000BF3403000B00000073616372656467726F76650000000001620000000D0800007E2200006ACCE4C4E59824C22E7BD7430B08853E7A1D0000060000007DD705000000000013070000C03403000B00000073616372656467726F76650000000001630000000D08000081220000E27448439C20B8413BADB043147505C07A1D0000060000007DD705000000000013070000C13403000B00000073616372656467726F76650000000001640000000D080000A52C00001D3881C41758F0C1BF7507C49E263CC07A1D0000060000007DD705000000000013070000C23403000B00000073616372656467726F76650000000001650000000D0800007F4900002AFCDFC350FBAFC249A10F45DC6348407A1D0000060000007DD705000000000013070000C33403000B00000073616372656467726F76650000000001660000000D080000864E0000B2BAFDC30EA194C0456125439D9DD0BF7A1D0000060000007DD705000000000013070000C43403000B00000073616372656467726F76650000000001670000000D08000003100300510B9DC4A58469C29AC057442634853F7A1D0000060000007DD705000000000013070000C53403000B00000073616372656467726F76650000000001680000006D210100532800003342A1C4BA946EC1E4E6914382E78A3F812F0000060000007DD705000000000000000000C63403000B00000073616372656467726F766500000000016D000000B71D000095070000823098C4987865C15486E243336FBDBF812F0000060000007DD705000000000000000000CB3403000B00000073616372656467726F766500000000016E000000DF940000ED3600002D5DA0C4967865C148BEB043753C46C0812F0000060000007DD705000000000000000000CC3403000B00000073616372656467726F76650000000001720000000D0800006532000052B8B442D7A3044248C1B2C3448B2CBF7A1D0000060000007DD705000000000013070000D03403000B00000073616372656467726F7665000000000173000000A5D70500EF2D03003B470EC4142E53C21D561F45B6F33DBF1F050000060000007DD705000000000007070000D13403000B00000073616372656467726F7665000000000174000000A5D70500F72D0300FA1E8543C3F5DA416AFCED43190496BF1F050000060000007DD705000000000007070000D23403000B00000073616372656467726F7665000000000175000000463606009B2B03002AF411C3B610C4C01AB18143AB3E41C025050000060000007DD705000000000059070000D33403000B00000073616372656467726F7665000000000176000000A5D705000F100300E6666FC28FECC340E58BA843D68D10401F050000060000007DD705000000000007070000D43403000B00000073616372656467726F766500000000017700000081540600D43703004F2915C5B34DBEC18E949A448D5D22BEC22E0000030000007DD705000000000000000000093803000B00000073616372656467726F76650000000001780000000F3C06004E3203001E5FA5C427A581C22E4A62445CACA83D45520000060000007DD7050000000000000000008D0200000B00000073616372656467726F76650000000001790000006EC4010004100300C50B91C48EC622C23E163A44E59BEDBEC22E0000030000007DD705000000000000000000614903000B00000073616372656467726F766500000000017A000000A5D705008E5C0300574F63C2C1E34CC2704F2B457592E5BE1F050000060000007DD7050000000000070700008E5C03000B00000073616372656467726F766500000000017B00000020820600CB01000081FD13C44A0C1A406FA68DC4A470EDBFFB6E0000060000007DD705000000000000000000CB0100000B00000073616372656467726F766500000000017C00000020820600CD010000568EC142560ED1417DEF944373682140FB6E0000060000007DD705000000000000000000CD0100000B00000073616372656467726F766500000000017D00000020820600CE010000CD1441C47F6AC4C093484444A470EDBFFB6E0000060000007DD705000000000000000000CE0100000B00000073616372656467726F766500000000017E00000020820600CF01000096BB79C404D610C25C6F7FC38D97EE3FFB6E0000060000007DD705000000000000000000CF0100000B00000073616372656467726F766500000000017F0000000E6E010050320300688433C46362DCC0D551454456F1463F45520000060000007DD7050000000000000000008E0200000B00000073616372656467726F76650000000001800000001C3C06004C320300C5F532C4528F89C2F09416457DE80ABF45520000060000007DD705000000000000000000E45C03000B00000073616372656467726F7665000000000181000000173C06004D320300361506C47F7E94C2A12CFD44E9B7294045520000060000007DD705000000000000000000E55C03000B00000073616372656467726F76650000000001820000002E3C06005A320300E83AC043A75AC442625DF742DB32603D45520000060000007DD705000000000000000000E75C03000B00000073616372656467726F7665000000000183000000403C06005B320300F2DAFE42F33CCF41CE13C7431170C03F45520000060000007DD705000000000000000000E65C03000B00000073616372656467726F76650000000001840000003A870600445F03005F2DEEC3F2352DC27837A6C4A6B88ABEF1760000060000007DD705000000000000000000160000000B00000073616372656467726F7665000000000185000000251B0000AF6703005856B7C443F91BC25A8E04C45A0DA93F37880000060000007DD705000000000000000000E26903000B00000073616372656467726F766500000000018600000008A20600D36D0300B2CD0DC46F12D33FFE14E642000040C0FA8A0000060000007DD705000000000000000000D36D03000B00000073616372656467726F76650000000001870000000AA20600D46D0300E78FD1C44E6276C19C04F742000000C0FA8A0000060000007DD705000000000000000000D46D03000B00000073616372656467726F76650000000001880000000BA20600D56D0300CB0505C5A69BFCC1FEA42E44F4FD3C40FA8A0000060000007DD705000000000000000000D56D03000B00000073616372656467726F766500000000018900000061A80600CB6F0300D8148FC46694F7C15101C1C382AD38C0E2910000060000007DD705000000000000000000CB6F03000B00000073616372656467726F766500000000018A00000061A80600CC6F0300883AA4C45D8275C10BE39143A6D5E8BFE2910000060000007DD705000000000000000000CC6F03000B00000073616372656467726F766500000000018B00000061A80600D06F03006D2313C457078A3F1B8E8FC484D92FC0E2910000060000007DD705000000000000000000D06F03000B00000073616372656467726F766500000000018C00000047550600D36F030031ACA3C4B81E75C1C5E09643621040C069570000060000007DD705000000000000000000D36F03000B00000073616372656467726F766500000000019200000018B306009EEA03005B3CD643160D8F42F810E6443F1C0D40C22E0000030000007DD705008B0200000000000099EA03000800000073756E73746F6E650000000001930000005C2506003634030021EFD14350BE014176EF0A45FEB6173EB19B00000A0000008B0200008B020000000000009BEA03000800000073756E73746F6E6500000000019400000019B306009FEA03006AE51D44B9BBA242091DDC4493FDB3BDC22E0000030000007DD705008B020000000000009DEA03000800000073756E73746F6E650000000001950000009C060000D3EE0300AFBB0F4486DDB1426842F744A5A4473D911D0000060000007DD705008B02000000000000370800000800000073756E73746F6E650000000001960000009D0600005AEF0300D6EA6144BCB36EBF57F8F644ACE2F93F911D0000060000007DD705008B02000000000000380800000800000073756E73746F6E650000000001970000009E06000036F00300AB7DFA4369198F42F861DE44971C973E41050000070000007DD705008B02000000000000390800000800000073756E73746F6E656400000001980000009F06000037F0030057836144D6716A4015B50B45E41132C041050000070000007DD705008B020000000000003A0800000800000073756E73746F6E65640000000199000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000097050000000000000000000001A000000048BC060035F103007364A0C4000060C189B1A8436ABCF4BE7E030000060000007DD70500000000000000000035F103000B00000073616372656467726F76650000000001A100000048BC060036F103004AAC4A430000E0410AF7D0430AD793BF7E030000060000007DD70500000000000000000036F103000B00000073616372656467726F76650000000001A200000048BC060037F103004E12CCC300003041E7878EC4A24506407E030000060000007DD70500000000000000000037F103000B00000073616372656467726F76650000000001A3000000F8670600A5050000B87E61436F12BB41F242C74391ED8C3F866E0000060000007DD705000000000000000000A50500000B00000073616372656467726F76650000000001A40000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000AA0500000B00000073616372656467726F76650000000001A500000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000008CF103000B00000073616372656467726F76650000000001A6000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000013F303000B00000073616372656467726F76650000000001A7000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000014F303000B00000073616372656467726F76650000000001A8000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000015F303000B00000073616372656467726F76650000000001A9000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000016F303000B00000073616372656467726F76650000000001AA000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000090F30300000000000000000001AB000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000050F50300000000000000000001AC00000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000007BF60300000000000000000001AD00000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000006B340300000000000000000001AE0000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000F4F80300000000000000000001AF000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000066F90300000000000000000001B000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000008DF903000B00000073616372656467726F76650000000000"));
        }

        public static void SendPacketPOIChangeMessage(SOEClient soeClient)
        {
            //TODO
            LoginManager.SendTunneledClientPacket(soeClient, LoginManager.StringToByteArray(/* PacketPOIChangeMessage */ "0500010E0000006800AB0D00000500000023010000"));
        }

        public static void SendObjectiveTargetUpdatePacket(SOEClient soeClient)
        {
            LoginManager.SendTunneledClientPacket(soeClient, LoginManager.StringToByteArray(/* Quest Marker */"2F000E017B10CEC614CA943E01000000320000006027000068BF06000CA7B9C3CB9AA4C2C62E16450000803F05000000"));
        }
    }
}
