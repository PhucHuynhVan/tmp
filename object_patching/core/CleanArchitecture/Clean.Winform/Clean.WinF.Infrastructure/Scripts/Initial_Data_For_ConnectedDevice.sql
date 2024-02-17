/*
Add ConnectedDevice use for Sewing Machine
*/
INSERT INTO ConnectedDevice (ID, Name, DeviceRoutingID, DeviceTypeID, PortID, ZebraScannerSerialNumber, IsExit)
SELECT 1, "lower thread scanner", 1, 6, 1, '', 1
WHERE NOT EXISTS (SELECT 1 FROM ConnectedDevice WHERE Name = "lower thread scanner");

INSERT INTO ConnectedDevice (ID, Name, DeviceRoutingID, DeviceTypeID, PortID, ZebraScannerSerialNumber, IsExit)
SELECT 2, "upper thread scanner", 2, 6, 1, '', 1
WHERE NOT EXISTS (SELECT 1 FROM ConnectedDevice WHERE Name = "upper thread scanner");

INSERT INTO ConnectedDevice (ID, Name, DeviceRoutingID, DeviceTypeID, PortID, ZebraScannerSerialNumber, IsExit)
SELECT 3, "bobbin scanner", 3, 1, 5, '', 1
WHERE NOT EXISTS (SELECT 1 FROM ConnectedDevice WHERE Name = "bobbin scanner");

INSERT INTO ConnectedDevice (ID, Name, DeviceRoutingID, DeviceTypeID, PortID, ZebraScannerSerialNumber, IsExit)
SELECT 4, "hand held scanner", 5, 1, 5, '', 1
WHERE NOT EXISTS (SELECT 1 FROM ConnectedDevice WHERE Name = "hand held scanner");

INSERT INTO ConnectedDevice (ID, Name, DeviceRoutingID, DeviceTypeID, PortID, ZebraScannerSerialNumber, IsExit)
SELECT 5, "endlabel scanner", 5, 1, 6, '', 1
WHERE NOT EXISTS (SELECT 1 FROM ConnectedDevice WHERE Name = "endlabel scanner");

INSERT INTO ConnectedDevice (ID, Name, DeviceRoutingID, DeviceTypeID, PortID, ZebraScannerSerialNumber, IsExit)
SELECT 6, "PCL (sewing machine)", 8, 2, 1, '', 1
WHERE NOT EXISTS (SELECT 1 FROM ConnectedDevice WHERE Name = "PCL (sewing machine)");

INSERT INTO ConnectedDevice (ID, Name, DeviceRoutingID, DeviceTypeID, PortID, ZebraScannerSerialNumber, IsExit)
SELECT 7, "upper thread tension monitor", 10, 4, 10, '', 1
WHERE NOT EXISTS (SELECT 1 FROM ConnectedDevice WHERE Name = "upper thread tension monitor");

INSERT INTO ConnectedDevice (ID, Name, DeviceRoutingID, DeviceTypeID, PortID, ZebraScannerSerialNumber, IsExit)
SELECT 8, "keyboard", 11, 3, 2, '', 1
WHERE NOT EXISTS (SELECT 1 FROM ConnectedDevice WHERE Name = "keyboard");