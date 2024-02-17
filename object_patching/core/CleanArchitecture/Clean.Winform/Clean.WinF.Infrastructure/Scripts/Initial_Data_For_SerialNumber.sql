/*
Add SerialNumber use for SerialNumber
*/
INSERT INTO SerialNumber (ID, Name, InternalName, CounterTypeName, ResetTypeName, CurrentSerialNumber, MaximumValue, ResetDate)
SELECT 112234, "SADE_01", "SADE;Max1336335;ResetWhenExceed", "1 serial number for each machine", "when [maximum value] is exceeded", 0, 9999, CURRENT_DATE
WHERE NOT EXISTS (SELECT 1 FROM SerialNumber WHERE Name = "SADE_01");