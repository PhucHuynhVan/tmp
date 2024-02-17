/*
Add DeviceType use for Sewing Machine
*/
INSERT INTO DeviceType (ID, Name)
SELECT 1, "Handheld Scanner"
WHERE NOT EXISTS (SELECT 1 FROM DeviceType WHERE Name = "Handheld Scanner");

INSERT INTO DeviceType (ID, Name)
SELECT 2, "Efka - SPS"
WHERE NOT EXISTS (SELECT 1 FROM DeviceType WHERE Name = "Efka - SPS");

INSERT INTO DeviceType (ID, Name)
SELECT 3, "Tastatur"
WHERE NOT EXISTS (SELECT 1 FROM DeviceType WHERE Name = "Tastatur");

INSERT INTO DeviceType (ID, Name)
SELECT 4, "ETM-422"
WHERE NOT EXISTS (SELECT 1 FROM DeviceType WHERE Name = "ETM-422");

INSERT INTO DeviceType (ID, Name)
SELECT 5, "SSI-Scanner"
WHERE NOT EXISTS (SELECT 1 FROM DeviceType WHERE Name = "SSI-Scanner");

INSERT INTO DeviceType (ID, Name)
SELECT 6, "Zebra Scanner"
WHERE NOT EXISTS (SELECT 1 FROM DeviceType WHERE Name = "Zebra Scanner");
