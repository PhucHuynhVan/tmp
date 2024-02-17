/*
Add Role
*/
INSERT INTO Role (ID, Name, Description, IsActive, CreatedOn, UpdatedOn)
SELECT 1, 'Administrator', 'all permission', 1, DATETIME('now'), DATETIME('now')
WHERE NOT EXISTS (SELECT 1 FROM Role WHERE Name = 'Administrator');

INSERT INTO Role (ID, Name, Description, IsActive, CreatedOn, UpdatedOn)
SELECT 2, 'Power User', 'sewing: extended BiasysControl and BiasysDB permissions', 1, DATETIME('now'), DATETIME('now')
WHERE NOT EXISTS (SELECT 1 FROM Role WHERE Name = 'Power User');

INSERT INTO Role (ID, Name, Description, IsActive, CreatedOn, UpdatedOn)
SELECT 3, 'Sewing User', 'sewing', 1, DATETIME('now'), DATETIME('now')
WHERE NOT EXISTS (SELECT 1 FROM Role WHERE Name = 'Sewing User');

INSERT INTO Role (ID, Name, Description, IsActive, CreatedOn, UpdatedOn)
SELECT 4, 'Sewing', 'sewing: standard sewing', 1, DATETIME('now'), DATETIME('now')
WHERE NOT EXISTS (SELECT 1 FROM Role WHERE Name = 'Sewing');