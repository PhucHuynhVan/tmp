/*
Add ClipSenSorActivation use for Sewing Machine
*/
INSERT INTO ClipSenSorActivation (ID, Name, IsActive, CreatedOn, UpdatedOn)
SELECT 1, 'Alway ON', 1, DATETIME('now'), DATETIME('now')
WHERE NOT EXISTS (SELECT 1 FROM ClipSenSorActivation WHERE Name = 'Alway ON');

INSERT INTO ClipSenSorActivation (ID, Name, IsActive, CreatedOn, UpdatedOn)
SELECT 2, 'ON After Min.Stitches minus [X] Stitches', 1, DATETIME('now'), DATETIME('now')
WHERE NOT EXISTS (SELECT 1 FROM ClipSenSorActivation WHERE Name = 'ON After Min.Stitches minus [X] Stitches');