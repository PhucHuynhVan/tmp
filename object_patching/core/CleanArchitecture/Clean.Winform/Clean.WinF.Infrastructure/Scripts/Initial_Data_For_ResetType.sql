/*
Add ResetType use for SerialNumber
*/
INSERT INTO ResetType (ID, Name)
SELECT 1, "never"
WHERE NOT EXISTS (SELECT 1 FROM ResetType WHERE Name = "never");

INSERT INTO ResetType (ID, Name)
SELECT 2, "daily"
WHERE NOT EXISTS (SELECT 1 FROM ResetType WHERE Name = "daily");

INSERT INTO ResetType (ID, Name)
SELECT 3, "weekly"
WHERE NOT EXISTS (SELECT 1 FROM ResetType WHERE Name = "weekly");

INSERT INTO ResetType (ID, Name)
SELECT 4, "when [maximum value] is exceeded"
WHERE NOT EXISTS (SELECT 1 FROM ResetType WHERE Name = "when [maximum value] is exceeded");