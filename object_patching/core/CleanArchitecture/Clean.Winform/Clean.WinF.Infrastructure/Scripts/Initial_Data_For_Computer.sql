INSERT INTO Computer (Name, MachineNumber, IsActive)
SELECT '{0}',1, 1
WHERE NOT EXISTS (SELECT 1 FROM Computer WHERE Name = '{0}');