/*
Add CounterType use for SerialNumber
*/
INSERT INTO CounterType (ID, Name)
SELECT 1, "1 serial number for each machine"
WHERE NOT EXISTS (SELECT 1 FROM CounterType WHERE Name = "1 serial number for each machine");

INSERT INTO CounterType (ID, Name)
SELECT 2, "1 serial number for all machines"
WHERE NOT EXISTS (SELECT 1 FROM CounterType WHERE Name = "1 serial number for all machines");