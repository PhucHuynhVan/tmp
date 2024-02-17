/*
Add DeviceRouting use for Sewing Machine
*/
INSERT INTO DeviceRouting (ID, Name)
SELECT 1, "lower thread scanner"
WHERE NOT EXISTS (SELECT 1 FROM DeviceRouting WHERE Name = "lower thread scanner");

INSERT INTO DeviceRouting (ID, Name)
SELECT 2, "upper thread scanner"
WHERE NOT EXISTS (SELECT 1 FROM DeviceRouting WHERE Name = "upper thread scanner");

INSERT INTO DeviceRouting (ID, Name)
SELECT 3, "bobbin scanner"
WHERE NOT EXISTS (SELECT 1 FROM DeviceRouting WHERE Name = "bobbin scanner");

INSERT INTO DeviceRouting (ID, Name)
SELECT 4, "bobbin windding scanner"
WHERE NOT EXISTS (SELECT 1 FROM DeviceRouting WHERE Name = "bobbin windding scanner");

INSERT INTO DeviceRouting (ID, Name)
SELECT 5, "hand held scanner"
WHERE NOT EXISTS (SELECT 1 FROM DeviceRouting WHERE Name = "hand held scanner");

INSERT INTO DeviceRouting (ID, Name)
SELECT 6, "endlabel scanner"
WHERE NOT EXISTS (SELECT 1 FROM DeviceRouting WHERE Name = "endlabel scanner");

INSERT INTO DeviceRouting (ID, Name)
SELECT 7, "endlabel scanner"
WHERE NOT EXISTS (SELECT 1 FROM DeviceRouting WHERE Name = "endlabel scanner");

INSERT INTO DeviceRouting (ID, Name)
SELECT 8, "PCL (sewing machine)"
WHERE NOT EXISTS (SELECT 1 FROM DeviceRouting WHERE Name = "PCL (sewing machine)");

INSERT INTO DeviceRouting (ID, Name)
SELECT 9, "lower thread tension monitor"
WHERE NOT EXISTS (SELECT 1 FROM DeviceRouting WHERE Name = "lower thread tension monitor");

INSERT INTO DeviceRouting (ID, Name)
SELECT 10, "upper thread tension monitor"
WHERE NOT EXISTS (SELECT 1 FROM DeviceRouting WHERE Name = "upper thread tension monitor");

INSERT INTO DeviceRouting (ID, Name)
SELECT 11, "keyboard"
WHERE NOT EXISTS (SELECT 1 FROM DeviceRouting WHERE Name = "keyboard");