INSERT INTO "User" (Name, Password, UserID, RoleID, IsActive, ExpiryDate, LoginAllowed, FingerDataAvailable)
SELECT 'admin', 'rSyEXo11D0B0/SqZ+QB1/A==' , 'admin', 1, 1, DATETIME('now'), 1, '123456'
WHERE NOT EXISTS (SELECT 1 FROM "User" WHERE UserID = 'admin');