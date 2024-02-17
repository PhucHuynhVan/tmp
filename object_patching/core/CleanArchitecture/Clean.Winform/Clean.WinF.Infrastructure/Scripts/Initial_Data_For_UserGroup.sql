/*
For Administaartor
*/
INSERT INTO UserGroup (RoleID, PermissionID,IsActive, IsRead, IsInsert, IsDelete, IsExecute)
SELECT 1, 1, 1, 0, 0, 0, 1
WHERE NOT EXISTS (SELECT 1 FROM UserGroup WHERE RoleID = 1 AND PermissionID = 1);

INSERT INTO UserGroup (RoleID, PermissionID,IsActive, IsRead, IsInsert, IsDelete, IsExecute)
SELECT 1, 2, 1, 0, 0, 0, 1
WHERE NOT EXISTS (SELECT 1 FROM UserGroup WHERE RoleID = 1 AND PermissionID = 2);

INSERT INTO UserGroup (RoleID, PermissionID,IsActive, IsRead, IsInsert, IsDelete, IsExecute)
SELECT 1, 3, 1, 0, 0, 0, 1
WHERE NOT EXISTS (SELECT 1 FROM UserGroup WHERE RoleID = 1 AND PermissionID = 3);

INSERT INTO UserGroup (RoleID, PermissionID,IsActive, IsRead, IsInsert, IsDelete, IsExecute)
SELECT 1, 4, 1, 0, 0, 0, 1
WHERE NOT EXISTS (SELECT 1 FROM UserGroup WHERE RoleID = 1 AND PermissionID = 4);

INSERT INTO UserGroup (RoleID, PermissionID,IsActive, IsRead, IsInsert, IsDelete, IsExecute)
SELECT 1, 5, 1, 0, 0, 0, 1
WHERE NOT EXISTS (SELECT 1 FROM UserGroup WHERE RoleID = 1 AND PermissionID = 5);

INSERT INTO UserGroup (RoleID, PermissionID,IsActive, IsRead, IsInsert, IsDelete, IsExecute)
SELECT 1, 6, 1, 0, 0, 0, 1
WHERE NOT EXISTS (SELECT 1 FROM UserGroup WHERE RoleID = 1 AND PermissionID = 6);

INSERT INTO UserGroup (RoleID, PermissionID,IsActive, IsRead, IsInsert, IsDelete, IsExecute)
SELECT 1, 7, 1, 0, 0, 0, 1
WHERE NOT EXISTS (SELECT 1 FROM UserGroup WHERE RoleID = 1 AND PermissionID = 7);

INSERT INTO UserGroup (RoleID, PermissionID,IsActive, IsRead, IsInsert, IsDelete, IsExecute)
SELECT 1, 8, 1, 0, 0, 0, 1
WHERE NOT EXISTS (SELECT 1 FROM UserGroup WHERE RoleID = 1 AND PermissionID = 8);

INSERT INTO UserGroup (RoleID, PermissionID,IsActive, IsRead, IsInsert, IsDelete, IsExecute)
SELECT 1, 9, 1, 0, 0, 0, 1
WHERE NOT EXISTS (SELECT 1 FROM UserGroup WHERE RoleID = 1 AND PermissionID = 9);

INSERT INTO UserGroup (RoleID, PermissionID,IsActive, IsRead, IsInsert, IsDelete, IsExecute)
SELECT 1, 10, 1, 0, 0, 0, 1
WHERE NOT EXISTS (SELECT 1 FROM UserGroup WHERE RoleID = 1 AND PermissionID = 10);

INSERT INTO UserGroup (RoleID, PermissionID,IsActive, IsRead, IsInsert, IsDelete, IsExecute)
SELECT 1, 12, 1, 1, 1, 1, 0
WHERE NOT EXISTS (SELECT 1 FROM UserGroup WHERE RoleID = 1 AND PermissionID = 12);

INSERT INTO UserGroup (RoleID, PermissionID,IsActive, IsRead, IsInsert, IsDelete, IsExecute)
SELECT 1, 13, 1, 1, 1, 1, 0
WHERE NOT EXISTS (SELECT 1 FROM UserGroup WHERE RoleID = 1 AND PermissionID = 13);

INSERT INTO UserGroup (RoleID, PermissionID,IsActive, IsRead, IsInsert, IsDelete, IsExecute)
SELECT 1, 14, 1, 0, 0, 0, 1
WHERE NOT EXISTS (SELECT 1 FROM UserGroup WHERE RoleID = 1 AND PermissionID = 14);

INSERT INTO UserGroup (RoleID, PermissionID,IsActive, IsRead, IsInsert, IsDelete, IsExecute)
SELECT 1, 15, 1, 0, 0, 0, 1
WHERE NOT EXISTS (SELECT 1 FROM UserGroup WHERE RoleID = 1 AND PermissionID = 15);

INSERT INTO UserGroup (RoleID, PermissionID,IsActive, IsRead, IsInsert, IsDelete, IsExecute)
SELECT 1, 16, 1, 1, 1, 1, 0
WHERE NOT EXISTS (SELECT 1 FROM UserGroup WHERE RoleID = 1 AND PermissionID = 16);

INSERT INTO UserGroup (RoleID, PermissionID,IsActive, IsRead, IsInsert, IsDelete, IsExecute)
SELECT 1, 17, 1, 1, 1, 1, 0
WHERE NOT EXISTS (SELECT 1 FROM UserGroup WHERE RoleID = 1 AND PermissionID = 17);

INSERT INTO UserGroup (RoleID, PermissionID,IsActive, IsRead, IsInsert, IsDelete, IsExecute)
SELECT 1, 18, 1, 1, 1, 1, 0
WHERE NOT EXISTS (SELECT 1 FROM UserGroup WHERE RoleID = 1 AND PermissionID = 18);

INSERT INTO UserGroup (RoleID, PermissionID,IsActive, IsRead, IsInsert, IsDelete, IsExecute)
SELECT 1, 19, 1, 1, 1, 1, 0
WHERE NOT EXISTS (SELECT 1 FROM UserGroup WHERE RoleID = 1 AND PermissionID = 19);

INSERT INTO UserGroup (RoleID, PermissionID,IsActive, IsRead, IsInsert, IsDelete, IsExecute)
SELECT 1, 20, 1, 0, 0, 0, 1
WHERE NOT EXISTS (SELECT 1 FROM UserGroup WHERE RoleID = 1 AND PermissionID = 20);

INSERT INTO UserGroup (RoleID, PermissionID,IsActive, IsRead, IsInsert, IsDelete, IsExecute)
SELECT 1, 22, 1, 1, 1, 1, 0
WHERE NOT EXISTS (SELECT 1 FROM UserGroup WHERE RoleID = 1 AND PermissionID = 22);

INSERT INTO UserGroup (RoleID, PermissionID,IsActive, IsRead, IsInsert, IsDelete, IsExecute)
SELECT 1, 24, 1, 1, 1, 1, 0
WHERE NOT EXISTS (SELECT 1 FROM UserGroup WHERE RoleID = 1 AND PermissionID = 24);

INSERT INTO UserGroup (RoleID, PermissionID,IsActive, IsRead, IsInsert, IsDelete, IsExecute)
SELECT 1, 25, 1, 1, 1, 1, 0
WHERE NOT EXISTS (SELECT 1 FROM UserGroup WHERE RoleID = 1 AND PermissionID = 25);

INSERT INTO UserGroup (RoleID, PermissionID,IsActive, IsRead, IsInsert, IsDelete, IsExecute)
SELECT 1, 26, 1, 1, 1, 1, 0
WHERE NOT EXISTS (SELECT 1 FROM UserGroup WHERE RoleID = 1 AND PermissionID = 26);

INSERT INTO UserGroup (RoleID, PermissionID,IsActive, IsRead, IsInsert, IsDelete, IsExecute)
SELECT 1, 27, 1, 1, 1, 1, 0
WHERE NOT EXISTS (SELECT 1 FROM UserGroup WHERE RoleID = 1 AND PermissionID = 27);

INSERT INTO UserGroup (RoleID, PermissionID,IsActive, IsRead, IsInsert, IsDelete, IsExecute)
SELECT 1, 28, 1, 1, 1, 1, 0
WHERE NOT EXISTS (SELECT 1 FROM UserGroup WHERE RoleID = 1 AND PermissionID = 28);

INSERT INTO UserGroup (RoleID, PermissionID,IsActive, IsRead, IsInsert, IsDelete, IsExecute)
SELECT 1, 29, 1, 1, 1, 1, 0
WHERE NOT EXISTS (SELECT 1 FROM UserGroup WHERE RoleID = 1 AND PermissionID = 29);

INSERT INTO UserGroup (RoleID, PermissionID,IsActive, IsRead, IsInsert, IsDelete, IsExecute)
SELECT 1, 46, 1, 0, 0, 0, 1
WHERE NOT EXISTS (SELECT 1 FROM UserGroup WHERE RoleID = 1 AND PermissionID = 46);

INSERT INTO UserGroup (RoleID, PermissionID,IsActive, IsRead, IsInsert, IsDelete, IsExecute)
SELECT 1, 35, 1, 0, 0, 0, 1
WHERE NOT EXISTS (SELECT 1 FROM UserGroup WHERE RoleID = 1 AND PermissionID = 35);

INSERT INTO UserGroup (RoleID, PermissionID,IsActive, IsRead, IsInsert, IsDelete, IsExecute)
SELECT 1, 36, 1, 0, 0, 0, 1
WHERE NOT EXISTS (SELECT 1 FROM UserGroup WHERE RoleID = 1 AND PermissionID = 36);

INSERT INTO UserGroup (RoleID, PermissionID,IsActive, IsRead, IsInsert, IsDelete, IsExecute)
SELECT 1, 37, 1, 0, 0, 0, 1
WHERE NOT EXISTS (SELECT 1 FROM UserGroup WHERE RoleID = 1 AND PermissionID = 37);

INSERT INTO UserGroup (RoleID, PermissionID,IsActive, IsRead, IsInsert, IsDelete, IsExecute)
SELECT 1, 38, 1, 1, 1, 1, 0
WHERE NOT EXISTS (SELECT 1 FROM UserGroup WHERE RoleID = 1 AND PermissionID = 38);

INSERT INTO UserGroup (RoleID, PermissionID,IsActive, IsRead, IsInsert, IsDelete, IsExecute)
SELECT 1, 39, 1, 0, 0, 0, 1
WHERE NOT EXISTS (SELECT 1 FROM UserGroup WHERE RoleID = 1 AND PermissionID = 39);

/*
For Power User
*/
INSERT INTO UserGroup (RoleID, PermissionID,IsActive, IsRead, IsInsert, IsDelete, IsExecute)
SELECT 2, 1, 1, 0, 0, 0, 1
WHERE NOT EXISTS (SELECT 1 FROM UserGroup WHERE RoleID = 2 AND PermissionID = 1);

INSERT INTO UserGroup (RoleID, PermissionID,IsActive, IsRead, IsInsert, IsDelete, IsExecute)
SELECT 2, 2, 1, 0, 0, 0, 1
WHERE NOT EXISTS (SELECT 1 FROM UserGroup WHERE RoleID = 2 AND PermissionID = 2);

INSERT INTO UserGroup (RoleID, PermissionID,IsActive, IsRead, IsInsert, IsDelete, IsExecute)
SELECT 2, 3, 1, 0, 0, 0, 1
WHERE NOT EXISTS (SELECT 1 FROM UserGroup WHERE RoleID = 2 AND PermissionID = 3);

INSERT INTO UserGroup (RoleID, PermissionID,IsActive, IsRead, IsInsert, IsDelete, IsExecute)
SELECT 2, 4, 1, 0, 0, 0, 1
WHERE NOT EXISTS (SELECT 1 FROM UserGroup WHERE RoleID = 2 AND PermissionID = 4);

INSERT INTO UserGroup (RoleID, PermissionID,IsActive, IsRead, IsInsert, IsDelete, IsExecute)
SELECT 2, 5, 1, 0, 0, 0, 1
WHERE NOT EXISTS (SELECT 1 FROM UserGroup WHERE RoleID = 2 AND PermissionID = 5);

INSERT INTO UserGroup (RoleID, PermissionID,IsActive, IsRead, IsInsert, IsDelete, IsExecute)
SELECT 2, 6, 1, 0, 0, 0, 1
WHERE NOT EXISTS (SELECT 1 FROM UserGroup WHERE RoleID = 2 AND PermissionID = 6);

INSERT INTO UserGroup (RoleID, PermissionID,IsActive, IsRead, IsInsert, IsDelete, IsExecute)
SELECT 2, 7, 1, 0, 0, 0, 1
WHERE NOT EXISTS (SELECT 1 FROM UserGroup WHERE RoleID = 2 AND PermissionID = 7);

INSERT INTO UserGroup (RoleID, PermissionID,IsActive, IsRead, IsInsert, IsDelete, IsExecute)
SELECT 2, 8, 1, 0, 0, 0, 1
WHERE NOT EXISTS (SELECT 1 FROM UserGroup WHERE RoleID = 2 AND PermissionID = 8);

INSERT INTO UserGroup (RoleID, PermissionID,IsActive, IsRead, IsInsert, IsDelete, IsExecute)
SELECT 2, 9, 1, 0, 0, 0, 1
WHERE NOT EXISTS (SELECT 1 FROM UserGroup WHERE RoleID = 2 AND PermissionID = 9);

INSERT INTO UserGroup (RoleID, PermissionID,IsActive, IsRead, IsInsert, IsDelete, IsExecute)
SELECT 2, 10, 1, 0, 0, 0, 1
WHERE NOT EXISTS (SELECT 1 FROM UserGroup WHERE RoleID = 2 AND PermissionID = 10);

INSERT INTO UserGroup (RoleID, PermissionID,IsActive, IsRead, IsInsert, IsDelete, IsExecute)
SELECT 2, 12, 1, 1, 1, 1, 0
WHERE NOT EXISTS (SELECT 1 FROM UserGroup WHERE RoleID = 2 AND PermissionID = 12);

INSERT INTO UserGroup (RoleID, PermissionID,IsActive, IsRead, IsInsert, IsDelete, IsExecute)
SELECT 2, 13, 1, 1, 1, 1, 0
WHERE NOT EXISTS (SELECT 1 FROM UserGroup WHERE RoleID = 2 AND PermissionID = 13);

INSERT INTO UserGroup (RoleID, PermissionID,IsActive, IsRead, IsInsert, IsDelete, IsExecute)
SELECT 2, 14, 1, 0, 0, 0, 0
WHERE NOT EXISTS (SELECT 1 FROM UserGroup WHERE RoleID = 2 AND PermissionID = 14);

INSERT INTO UserGroup (RoleID, PermissionID,IsActive, IsRead, IsInsert, IsDelete, IsExecute)
SELECT 2, 15, 1, 0, 0, 0, 0
WHERE NOT EXISTS (SELECT 1 FROM UserGroup WHERE RoleID = 2 AND PermissionID = 15);

INSERT INTO UserGroup (RoleID, PermissionID,IsActive, IsRead, IsInsert, IsDelete, IsExecute)
SELECT 2, 16, 1, 1, 1, 1, 0
WHERE NOT EXISTS (SELECT 1 FROM UserGroup WHERE RoleID = 2 AND PermissionID = 16);

INSERT INTO UserGroup (RoleID, PermissionID,IsActive, IsRead, IsInsert, IsDelete, IsExecute)
SELECT 2, 17, 1, 1, 1, 1, 0
WHERE NOT EXISTS (SELECT 1 FROM UserGroup WHERE RoleID = 2 AND PermissionID = 17);

INSERT INTO UserGroup (RoleID, PermissionID,IsActive, IsRead, IsInsert, IsDelete, IsExecute)
SELECT 2, 18, 1, 1, 1, 1, 0
WHERE NOT EXISTS (SELECT 1 FROM UserGroup WHERE RoleID = 2 AND PermissionID = 18);

INSERT INTO UserGroup (RoleID, PermissionID,IsActive, IsRead, IsInsert, IsDelete, IsExecute)
SELECT 2, 19, 1, 1, 1, 1, 0
WHERE NOT EXISTS (SELECT 1 FROM UserGroup WHERE RoleID = 2 AND PermissionID = 19);

INSERT INTO UserGroup (RoleID, PermissionID,IsActive, IsRead, IsInsert, IsDelete, IsExecute)
SELECT 2, 20, 1, 0, 0, 0, 1
WHERE NOT EXISTS (SELECT 1 FROM UserGroup WHERE RoleID = 2 AND PermissionID = 20);

INSERT INTO UserGroup (RoleID, PermissionID,IsActive, IsRead, IsInsert, IsDelete, IsExecute)
SELECT 2, 22, 1, 1, 1, 1, 0
WHERE NOT EXISTS (SELECT 1 FROM UserGroup WHERE RoleID = 2 AND PermissionID = 22);

INSERT INTO UserGroup (RoleID, PermissionID,IsActive, IsRead, IsInsert, IsDelete, IsExecute)
SELECT 2, 24, 1, 1, 1, 1, 0
WHERE NOT EXISTS (SELECT 1 FROM UserGroup WHERE RoleID = 2 AND PermissionID = 24);

INSERT INTO UserGroup (RoleID, PermissionID,IsActive, IsRead, IsInsert, IsDelete, IsExecute)
SELECT 2, 25, 1, 1, 1, 1, 0
WHERE NOT EXISTS (SELECT 1 FROM UserGroup WHERE RoleID = 2 AND PermissionID = 25);

INSERT INTO UserGroup (RoleID, PermissionID,IsActive, IsRead, IsInsert, IsDelete, IsExecute)
SELECT 2, 26, 1, 1, 1, 1, 0
WHERE NOT EXISTS (SELECT 1 FROM UserGroup WHERE RoleID = 2 AND PermissionID = 26);

INSERT INTO UserGroup (RoleID, PermissionID,IsActive, IsRead, IsInsert, IsDelete, IsExecute)
SELECT 2, 27, 1, 1, 1, 1, 0
WHERE NOT EXISTS (SELECT 1 FROM UserGroup WHERE RoleID = 2 AND PermissionID = 27);

INSERT INTO UserGroup (RoleID, PermissionID,IsActive, IsRead, IsInsert, IsDelete, IsExecute)
SELECT 2, 28, 1, 1, 1, 1, 0
WHERE NOT EXISTS (SELECT 1 FROM UserGroup WHERE RoleID = 2 AND PermissionID = 28);

INSERT INTO UserGroup (RoleID, PermissionID,IsActive, IsRead, IsInsert, IsDelete, IsExecute)
SELECT 2, 29, 1, 1, 1, 1, 0
WHERE NOT EXISTS (SELECT 1 FROM UserGroup WHERE RoleID = 2 AND PermissionID = 29);

INSERT INTO UserGroup (RoleID, PermissionID,IsActive, IsRead, IsInsert, IsDelete, IsExecute)
SELECT 2, 46, 1, 0, 0, 0, 1
WHERE NOT EXISTS (SELECT 1 FROM UserGroup WHERE RoleID = 2 AND PermissionID = 46);

INSERT INTO UserGroup (RoleID, PermissionID,IsActive, IsRead, IsInsert, IsDelete, IsExecute)
SELECT 2, 35, 1, 0, 0, 0, 1
WHERE NOT EXISTS (SELECT 1 FROM UserGroup WHERE RoleID = 2 AND PermissionID = 35);

INSERT INTO UserGroup (RoleID, PermissionID,IsActive, IsRead, IsInsert, IsDelete, IsExecute)
SELECT 2, 36, 1, 0, 0, 0, 1
WHERE NOT EXISTS (SELECT 1 FROM UserGroup WHERE RoleID = 2 AND PermissionID = 36);

INSERT INTO UserGroup (RoleID, PermissionID,IsActive, IsRead, IsInsert, IsDelete, IsExecute)
SELECT 2, 37, 1, 0, 0, 0, 0
WHERE NOT EXISTS (SELECT 1 FROM UserGroup WHERE RoleID = 2 AND PermissionID = 37);

INSERT INTO UserGroup (RoleID, PermissionID,IsActive, IsRead, IsInsert, IsDelete, IsExecute)
SELECT 2, 38, 1, 1, 0, 0, 0
WHERE NOT EXISTS (SELECT 1 FROM UserGroup WHERE RoleID = 2 AND PermissionID = 38);

INSERT INTO UserGroup (RoleID, PermissionID,IsActive, IsRead, IsInsert, IsDelete, IsExecute)
SELECT 2, 39, 1, 0, 0, 0, 1
WHERE NOT EXISTS (SELECT 1 FROM UserGroup WHERE RoleID = 2 AND PermissionID = 39);
/*
For Sewing
*/
INSERT INTO UserGroup (RoleID, PermissionID,IsActive, IsRead, IsInsert, IsDelete, IsExecute)
SELECT 3, 1, 1, 0, 0, 0, 1
WHERE NOT EXISTS (SELECT 1 FROM UserGroup WHERE RoleID = 3 AND PermissionID = 1);

INSERT INTO UserGroup (RoleID, PermissionID,IsActive, IsRead, IsInsert, IsDelete, IsExecute)
SELECT 3, 2, 1, 0, 0, 0, 0
WHERE NOT EXISTS (SELECT 1 FROM UserGroup WHERE RoleID = 3 AND PermissionID = 2);

INSERT INTO UserGroup (RoleID, PermissionID,IsActive, IsRead, IsInsert, IsDelete, IsExecute)
SELECT 3, 3, 1, 0, 0, 0, 0
WHERE NOT EXISTS (SELECT 1 FROM UserGroup WHERE RoleID = 3 AND PermissionID = 3);

INSERT INTO UserGroup (RoleID, PermissionID,IsActive, IsRead, IsInsert, IsDelete, IsExecute)
SELECT 3, 4, 1, 0, 0, 0, 0
WHERE NOT EXISTS (SELECT 1 FROM UserGroup WHERE RoleID = 3 AND PermissionID = 4);

INSERT INTO UserGroup (RoleID, PermissionID,IsActive, IsRead, IsInsert, IsDelete, IsExecute)
SELECT 3, 5, 1, 0, 0, 0, 0
WHERE NOT EXISTS (SELECT 1 FROM UserGroup WHERE RoleID = 3 AND PermissionID = 5);

INSERT INTO UserGroup (RoleID, PermissionID,IsActive, IsRead, IsInsert, IsDelete, IsExecute)
SELECT 3, 6, 1, 0, 0, 0, 0
WHERE NOT EXISTS (SELECT 1 FROM UserGroup WHERE RoleID = 3 AND PermissionID = 6);

INSERT INTO UserGroup (RoleID, PermissionID,IsActive, IsRead, IsInsert, IsDelete, IsExecute)
SELECT 3, 7, 1, 0, 0, 0, 0
WHERE NOT EXISTS (SELECT 1 FROM UserGroup WHERE RoleID = 3 AND PermissionID = 7);

INSERT INTO UserGroup (RoleID, PermissionID,IsActive, IsRead, IsInsert, IsDelete, IsExecute)
SELECT 3, 8, 1, 0, 0, 0, 0
WHERE NOT EXISTS (SELECT 1 FROM UserGroup WHERE RoleID = 3 AND PermissionID = 8);

INSERT INTO UserGroup (RoleID, PermissionID,IsActive, IsRead, IsInsert, IsDelete, IsExecute)
SELECT 3, 9, 1, 0, 0, 0, 0
WHERE NOT EXISTS (SELECT 1 FROM UserGroup WHERE RoleID = 3 AND PermissionID = 9);

INSERT INTO UserGroup (RoleID, PermissionID,IsActive, IsRead, IsInsert, IsDelete, IsExecute)
SELECT 3, 10, 1, 0, 0, 0, 0
WHERE NOT EXISTS (SELECT 1 FROM UserGroup WHERE RoleID = 3 AND PermissionID = 10);

INSERT INTO UserGroup (RoleID, PermissionID,IsActive, IsRead, IsInsert, IsDelete, IsExecute)
SELECT 3, 12, 1, 0, 0, 0, 0
WHERE NOT EXISTS (SELECT 1 FROM UserGroup WHERE RoleID = 3 AND PermissionID = 12);

INSERT INTO UserGroup (RoleID, PermissionID,IsActive, IsRead, IsInsert, IsDelete, IsExecute)
SELECT 3, 13, 1, 0, 0, 0, 0
WHERE NOT EXISTS (SELECT 1 FROM UserGroup WHERE RoleID = 3 AND PermissionID = 13);

INSERT INTO UserGroup (RoleID, PermissionID,IsActive, IsRead, IsInsert, IsDelete, IsExecute)
SELECT 3, 14, 1, 0, 0, 0, 0
WHERE NOT EXISTS (SELECT 1 FROM UserGroup WHERE RoleID = 3 AND PermissionID = 14);

INSERT INTO UserGroup (RoleID, PermissionID,IsActive, IsRead, IsInsert, IsDelete, IsExecute)
SELECT 3, 15, 1, 0, 0, 0, 0
WHERE NOT EXISTS (SELECT 1 FROM UserGroup WHERE RoleID = 3 AND PermissionID = 15);

INSERT INTO UserGroup (RoleID, PermissionID,IsActive, IsRead, IsInsert, IsDelete, IsExecute)
SELECT 3, 16, 1, 0, 0, 0, 0
WHERE NOT EXISTS (SELECT 1 FROM UserGroup WHERE RoleID = 3 AND PermissionID = 16);

INSERT INTO UserGroup (RoleID, PermissionID,IsActive, IsRead, IsInsert, IsDelete, IsExecute)
SELECT 3, 17, 1, 0, 0, 0, 0
WHERE NOT EXISTS (SELECT 1 FROM UserGroup WHERE RoleID = 3 AND PermissionID = 17);

INSERT INTO UserGroup (RoleID, PermissionID,IsActive, IsRead, IsInsert, IsDelete, IsExecute)
SELECT 3, 18, 1, 0, 0, 0, 0
WHERE NOT EXISTS (SELECT 1 FROM UserGroup WHERE RoleID = 3 AND PermissionID = 18);

INSERT INTO UserGroup (RoleID, PermissionID,IsActive, IsRead, IsInsert, IsDelete, IsExecute)
SELECT 3, 19, 1, 0, 0, 0, 0
WHERE NOT EXISTS (SELECT 1 FROM UserGroup WHERE RoleID = 3 AND PermissionID = 19);

INSERT INTO UserGroup (RoleID, PermissionID,IsActive, IsRead, IsInsert, IsDelete, IsExecute)
SELECT 3, 20, 1, 0, 0, 0, 0
WHERE NOT EXISTS (SELECT 1 FROM UserGroup WHERE RoleID = 3 AND PermissionID = 20);

INSERT INTO UserGroup (RoleID, PermissionID,IsActive, IsRead, IsInsert, IsDelete, IsExecute)
SELECT 3, 22, 1, 0, 0, 0, 0
WHERE NOT EXISTS (SELECT 1 FROM UserGroup WHERE RoleID = 3 AND PermissionID = 22);

INSERT INTO UserGroup (RoleID, PermissionID,IsActive, IsRead, IsInsert, IsDelete, IsExecute)
SELECT 3, 24, 1, 0, 0, 0, 0
WHERE NOT EXISTS (SELECT 1 FROM UserGroup WHERE RoleID = 3 AND PermissionID = 24);

INSERT INTO UserGroup (RoleID, PermissionID,IsActive, IsRead, IsInsert, IsDelete, IsExecute)
SELECT 3, 25, 1, 0, 0, 0, 0
WHERE NOT EXISTS (SELECT 1 FROM UserGroup WHERE RoleID = 3 AND PermissionID = 25);

INSERT INTO UserGroup (RoleID, PermissionID,IsActive, IsRead, IsInsert, IsDelete, IsExecute)
SELECT 3, 26, 1, 0, 0, 0, 0
WHERE NOT EXISTS (SELECT 1 FROM UserGroup WHERE RoleID = 3 AND PermissionID = 26);

INSERT INTO UserGroup (RoleID, PermissionID,IsActive, IsRead, IsInsert, IsDelete, IsExecute)
SELECT 3, 27, 1, 0, 0, 0, 0
WHERE NOT EXISTS (SELECT 1 FROM UserGroup WHERE RoleID = 3 AND PermissionID = 27);

INSERT INTO UserGroup (RoleID, PermissionID,IsActive, IsRead, IsInsert, IsDelete, IsExecute)
SELECT 3, 28, 1, 0, 0, 0, 0
WHERE NOT EXISTS (SELECT 1 FROM UserGroup WHERE RoleID = 3 AND PermissionID = 28);

INSERT INTO UserGroup (RoleID, PermissionID,IsActive, IsRead, IsInsert, IsDelete, IsExecute)
SELECT 3, 29, 1, 0, 0, 0, 0
WHERE NOT EXISTS (SELECT 1 FROM UserGroup WHERE RoleID = 3 AND PermissionID = 29);

INSERT INTO UserGroup (RoleID, PermissionID,IsActive, IsRead, IsInsert, IsDelete, IsExecute)
SELECT 3, 46, 1, 0, 0, 0, 0
WHERE NOT EXISTS (SELECT 1 FROM UserGroup WHERE RoleID = 3 AND PermissionID = 46);

INSERT INTO UserGroup (RoleID, PermissionID,IsActive, IsRead, IsInsert, IsDelete, IsExecute)
SELECT 3, 35, 1, 0, 0, 0, 0
WHERE NOT EXISTS (SELECT 1 FROM UserGroup WHERE RoleID = 3 AND PermissionID = 35);

INSERT INTO UserGroup (RoleID, PermissionID,IsActive, IsRead, IsInsert, IsDelete, IsExecute)
SELECT 3, 36, 1, 0, 0, 0, 0
WHERE NOT EXISTS (SELECT 1 FROM UserGroup WHERE RoleID = 3 AND PermissionID = 36);

INSERT INTO UserGroup (RoleID, PermissionID,IsActive, IsRead, IsInsert, IsDelete, IsExecute)
SELECT 3, 37, 1, 0, 0, 0, 0
WHERE NOT EXISTS (SELECT 1 FROM UserGroup WHERE RoleID = 3 AND PermissionID = 37);

INSERT INTO UserGroup (RoleID, PermissionID,IsActive, IsRead, IsInsert, IsDelete, IsExecute)
SELECT 3, 38, 1, 0, 0, 0, 0
WHERE NOT EXISTS (SELECT 1 FROM UserGroup WHERE RoleID = 3 AND PermissionID = 38);

INSERT INTO UserGroup (RoleID, PermissionID,IsActive, IsRead, IsInsert, IsDelete, IsExecute)
SELECT 3, 39, 1, 0, 0, 0, 0
WHERE NOT EXISTS (SELECT 1 FROM UserGroup WHERE RoleID = 3 AND PermissionID = 39);
/*
For Techinican
*/
INSERT INTO UserGroup (RoleID, PermissionID,IsActive, IsRead, IsInsert, IsDelete, IsExecute)
SELECT 4, 1, 1, 0, 0, 0, 1
WHERE NOT EXISTS (SELECT 1 FROM UserGroup WHERE RoleID = 4 AND PermissionID = 1);

INSERT INTO UserGroup (RoleID, PermissionID,IsActive, IsRead, IsInsert, IsDelete, IsExecute)
SELECT 4, 2, 1, 0, 0, 0, 0
WHERE NOT EXISTS (SELECT 1 FROM UserGroup WHERE RoleID = 4 AND PermissionID = 2);

INSERT INTO UserGroup (RoleID, PermissionID,IsActive, IsRead, IsInsert, IsDelete, IsExecute)
SELECT 4, 3, 1, 0, 0, 0, 0
WHERE NOT EXISTS (SELECT 1 FROM UserGroup WHERE RoleID = 4 AND PermissionID = 3);

INSERT INTO UserGroup (RoleID, PermissionID,IsActive, IsRead, IsInsert, IsDelete, IsExecute)
SELECT 4, 4, 1, 0, 0, 0, 0
WHERE NOT EXISTS (SELECT 1 FROM UserGroup WHERE RoleID = 4 AND PermissionID = 4);

INSERT INTO UserGroup (RoleID, PermissionID,IsActive, IsRead, IsInsert, IsDelete, IsExecute)
SELECT 4, 5, 1, 0, 0, 0, 1
WHERE NOT EXISTS (SELECT 1 FROM UserGroup WHERE RoleID = 4 AND PermissionID = 5);

INSERT INTO UserGroup (RoleID, PermissionID,IsActive, IsRead, IsInsert, IsDelete, IsExecute)
SELECT 4, 6, 1, 0, 0, 0, 0
WHERE NOT EXISTS (SELECT 1 FROM UserGroup WHERE RoleID = 4 AND PermissionID = 6);

INSERT INTO UserGroup (RoleID, PermissionID,IsActive, IsRead, IsInsert, IsDelete, IsExecute)
SELECT 4, 7, 1, 0, 0, 0, 0
WHERE NOT EXISTS (SELECT 1 FROM UserGroup WHERE RoleID = 4 AND PermissionID = 7);

INSERT INTO UserGroup (RoleID, PermissionID,IsActive, IsRead, IsInsert, IsDelete, IsExecute)
SELECT 4, 8, 1, 0, 0, 0, 0
WHERE NOT EXISTS (SELECT 1 FROM UserGroup WHERE RoleID = 4 AND PermissionID = 8);

INSERT INTO UserGroup (RoleID, PermissionID,IsActive, IsRead, IsInsert, IsDelete, IsExecute)
SELECT 4, 9, 1, 0, 0, 0, 0
WHERE NOT EXISTS (SELECT 1 FROM UserGroup WHERE RoleID = 4 AND PermissionID = 9);

INSERT INTO UserGroup (RoleID, PermissionID,IsActive, IsRead, IsInsert, IsDelete, IsExecute)
SELECT 4, 10, 1, 0, 0, 0, 0
WHERE NOT EXISTS (SELECT 1 FROM UserGroup WHERE RoleID = 4 AND PermissionID = 10);

INSERT INTO UserGroup (RoleID, PermissionID,IsActive, IsRead, IsInsert, IsDelete, IsExecute)
SELECT 4, 12, 1, 0, 0, 0, 0
WHERE NOT EXISTS (SELECT 1 FROM UserGroup WHERE RoleID = 4 AND PermissionID = 12);

INSERT INTO UserGroup (RoleID, PermissionID,IsActive, IsRead, IsInsert, IsDelete, IsExecute)
SELECT 4, 13, 1, 0, 0, 0, 0
WHERE NOT EXISTS (SELECT 1 FROM UserGroup WHERE RoleID = 4 AND PermissionID = 13);

INSERT INTO UserGroup (RoleID, PermissionID,IsActive, IsRead, IsInsert, IsDelete, IsExecute)
SELECT 4, 14, 1, 0, 0, 0, 0
WHERE NOT EXISTS (SELECT 1 FROM UserGroup WHERE RoleID = 4 AND PermissionID = 14);

INSERT INTO UserGroup (RoleID, PermissionID,IsActive, IsRead, IsInsert, IsDelete, IsExecute)
SELECT 4, 15, 1, 0, 0, 0, 0
WHERE NOT EXISTS (SELECT 1 FROM UserGroup WHERE RoleID = 4 AND PermissionID = 15);

INSERT INTO UserGroup (RoleID, PermissionID,IsActive, IsRead, IsInsert, IsDelete, IsExecute)
SELECT 4, 16, 1, 0, 0, 0, 0
WHERE NOT EXISTS (SELECT 1 FROM UserGroup WHERE RoleID = 4 AND PermissionID = 16);

INSERT INTO UserGroup (RoleID, PermissionID,IsActive, IsRead, IsInsert, IsDelete, IsExecute)
SELECT 4, 17, 1, 0, 0, 0, 0
WHERE NOT EXISTS (SELECT 1 FROM UserGroup WHERE RoleID = 4 AND PermissionID = 17);

INSERT INTO UserGroup (RoleID, PermissionID,IsActive, IsRead, IsInsert, IsDelete, IsExecute)
SELECT 4, 18, 1, 0, 0, 0, 0
WHERE NOT EXISTS (SELECT 1 FROM UserGroup WHERE RoleID = 4 AND PermissionID = 18);

INSERT INTO UserGroup (RoleID, PermissionID,IsActive, IsRead, IsInsert, IsDelete, IsExecute)
SELECT 4, 19, 1, 0, 0, 0, 0
WHERE NOT EXISTS (SELECT 1 FROM UserGroup WHERE RoleID = 4 AND PermissionID = 19);

INSERT INTO UserGroup (RoleID, PermissionID,IsActive, IsRead, IsInsert, IsDelete, IsExecute)
SELECT 4, 20, 1, 0, 0, 0, 0
WHERE NOT EXISTS (SELECT 1 FROM UserGroup WHERE RoleID = 4 AND PermissionID = 20);

INSERT INTO UserGroup (RoleID, PermissionID,IsActive, IsRead, IsInsert, IsDelete, IsExecute)
SELECT 4, 22, 1, 0, 0, 0, 0
WHERE NOT EXISTS (SELECT 1 FROM UserGroup WHERE RoleID = 4 AND PermissionID = 22);

INSERT INTO UserGroup (RoleID, PermissionID,IsActive, IsRead, IsInsert, IsDelete, IsExecute)
SELECT 4, 24, 1, 0, 0, 0, 0
WHERE NOT EXISTS (SELECT 1 FROM UserGroup WHERE RoleID = 4 AND PermissionID = 24);

INSERT INTO UserGroup (RoleID, PermissionID,IsActive, IsRead, IsInsert, IsDelete, IsExecute)
SELECT 4, 25, 1, 0, 0, 0, 0
WHERE NOT EXISTS (SELECT 1 FROM UserGroup WHERE RoleID = 4 AND PermissionID = 25);

INSERT INTO UserGroup (RoleID, PermissionID,IsActive, IsRead, IsInsert, IsDelete, IsExecute)
SELECT 4, 26, 1, 0, 0, 0, 0
WHERE NOT EXISTS (SELECT 1 FROM UserGroup WHERE RoleID = 4 AND PermissionID = 26);

INSERT INTO UserGroup (RoleID, PermissionID,IsActive, IsRead, IsInsert, IsDelete, IsExecute)
SELECT 4, 27, 1, 0, 0, 0, 0
WHERE NOT EXISTS (SELECT 1 FROM UserGroup WHERE RoleID = 4 AND PermissionID = 27);

INSERT INTO UserGroup (RoleID, PermissionID,IsActive, IsRead, IsInsert, IsDelete, IsExecute)
SELECT 4, 28, 1, 0, 0, 0, 0
WHERE NOT EXISTS (SELECT 1 FROM UserGroup WHERE RoleID = 4 AND PermissionID = 28);

INSERT INTO UserGroup (RoleID, PermissionID,IsActive, IsRead, IsInsert, IsDelete, IsExecute)
SELECT 4, 29, 1, 0, 0, 0, 0
WHERE NOT EXISTS (SELECT 1 FROM UserGroup WHERE RoleID = 4 AND PermissionID = 29);

INSERT INTO UserGroup (RoleID, PermissionID,IsActive, IsRead, IsInsert, IsDelete, IsExecute)
SELECT 4, 46, 1, 0, 0, 0, 0
WHERE NOT EXISTS (SELECT 1 FROM UserGroup WHERE RoleID = 4 AND PermissionID = 46);

INSERT INTO UserGroup (RoleID, PermissionID,IsActive, IsRead, IsInsert, IsDelete, IsExecute)
SELECT 4, 35, 1, 0, 0, 0, 0
WHERE NOT EXISTS (SELECT 1 FROM UserGroup WHERE RoleID = 4 AND PermissionID = 35);

INSERT INTO UserGroup (RoleID, PermissionID,IsActive, IsRead, IsInsert, IsDelete, IsExecute)
SELECT 4, 36, 1, 0, 0, 0, 0
WHERE NOT EXISTS (SELECT 1 FROM UserGroup WHERE RoleID = 4 AND PermissionID = 36);

INSERT INTO UserGroup (RoleID, PermissionID,IsActive, IsRead, IsInsert, IsDelete, IsExecute)
SELECT 4, 37, 1, 0, 0, 0, 0
WHERE NOT EXISTS (SELECT 1 FROM UserGroup WHERE RoleID = 4 AND PermissionID = 37);

INSERT INTO UserGroup (RoleID, PermissionID,IsActive, IsRead, IsInsert, IsDelete, IsExecute)
SELECT 4, 38, 1, 0, 0, 0, 0
WHERE NOT EXISTS (SELECT 1 FROM UserGroup WHERE RoleID = 4 AND PermissionID = 38);

INSERT INTO UserGroup (RoleID, PermissionID,IsActive, IsRead, IsInsert, IsDelete, IsExecute)
SELECT 4, 39, 1, 0, 0, 0, 0
WHERE NOT EXISTS (SELECT 1 FROM UserGroup WHERE RoleID = 4 AND PermissionID = 39);