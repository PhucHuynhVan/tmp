/*
Add for Permission
*/
INSERT INTO Permission (ID, Code, Name, IsActive, CreatedOn, UpdatedOn)
SELECT 1, 'SEWING', 'BiasysControl: Sewing', 1, DATETIME('now'), DATETIME('now')
WHERE NOT EXISTS (SELECT 1 FROM Permission WHERE Code = 'SEWING');

INSERT INTO Permission (ID, Code, Name, IsActive, CreatedOn, UpdatedOn)
SELECT 2, 'REPRINT_END_LABEL', 'BiasysControl: Reprint End Label', 1, DATETIME('now'), DATETIME('now')
WHERE NOT EXISTS (SELECT 1 FROM Permission WHERE Code = 'REPRINT_END_LABEL');

INSERT INTO Permission (ID, Code, Name, IsActive, CreatedOn, UpdatedOn)
SELECT 3, 'SEWING_ON_ERROR', 'BiasysControl: Continue Sewing on Error in Not Critical Seam', 1, DATETIME('now'), DATETIME('now')
WHERE NOT EXISTS (SELECT 1 FROM Permission WHERE Code = 'SEWING_ON_ERROR');

INSERT INTO Permission (ID, Code, Name, IsActive, CreatedOn, UpdatedOn)
SELECT 4, 'DEBUG_AUTOMAT', 'BiasysControl: Debug Automat', 1, DATETIME('now'), DATETIME('now')
WHERE NOT EXISTS (SELECT 1 FROM Permission WHERE Code = 'DEBUG_AUTOMAT');

INSERT INTO Permission (ID, Code, Name, IsActive, CreatedOn, UpdatedOn)
SELECT 5, 'STANDARD_SEWING', 'BiasysControl: Standard Sewing', 1, DATETIME('now'), DATETIME('now')
WHERE NOT EXISTS (SELECT 1 FROM Permission WHERE Code = 'STANDARD_SEWING');

INSERT INTO Permission (ID, Code, Name, IsActive, CreatedOn, UpdatedOn)
SELECT 6, 'RESCAN_END_LABEL', 'BiasysControl: Rescan Part Label', 1, DATETIME('now'), DATETIME('now')
WHERE NOT EXISTS (SELECT 1 FROM Permission WHERE Code = 'RESCAN_END_LABEL');

INSERT INTO Permission (ID, Code, Name, IsActive, CreatedOn, UpdatedOn)
SELECT 7, 'NEW_NEEDLE', 'BiasysControl: New Needle', 1, DATETIME('now'), DATETIME('now')
WHERE NOT EXISTS (SELECT 1 FROM Permission WHERE Code = 'NEW_NEEDLE');

INSERT INTO Permission (ID, Code, Name, IsActive, CreatedOn, UpdatedOn)
SELECT 8, 'CONFIRM_VALID_SEAM', 'BiasysControl: Confirm valid seam on too few ETM measurements', 1, DATETIME('now'), DATETIME('now')
WHERE NOT EXISTS (SELECT 1 FROM Permission WHERE Code = 'CONFIRM_VALID_SEAM');

INSERT INTO Permission (ID, Code, Name, IsActive, CreatedOn, UpdatedOn)
SELECT 9, 'CONFIRM_ETM_ADJUSTED', 'BiasysControl: Confirm that the ETM has been adjusted', 1, DATETIME('now'), DATETIME('now')
WHERE NOT EXISTS (SELECT 1 FROM Permission WHERE Code = 'CONFIRM_ETM_ADJUSTED');

INSERT INTO Permission (ID, Code, Name, IsActive, CreatedOn, UpdatedOn)
SELECT 10, 'SETTING_NOT_EDITABLE', 'BiasysControl: execute backup; setting not editable', 1, DATETIME('now'), DATETIME('now')
WHERE NOT EXISTS (SELECT 1 FROM Permission WHERE Code = 'SETTING_NOT_EDITABLE');

INSERT INTO Permission (ID, Code, Name, IsActive, CreatedOn, UpdatedOn)
SELECT 11, 'SETTING_EDITABLE', 'BiasysControl: execute backup; setting editable', 0, DATETIME('now'), DATETIME('now')
WHERE NOT EXISTS (SELECT 1 FROM Permission WHERE Code = 'SETTING_EDITABLE');

INSERT INTO Permission (ID, Code, Name, IsActive, CreatedOn, UpdatedOn)
SELECT 12, 'USER_MANAGEMENT', 'BiasysDB: Form [User Management]', 1, DATETIME('now'), DATETIME('now')
WHERE NOT EXISTS (SELECT 1 FROM Permission WHERE Code = 'USER_MANAGEMENT');

INSERT INTO Permission (ID, Code, Name, IsActive, CreatedOn, UpdatedOn)
SELECT 13, 'USER_GROUP', 'BiasysDB: Form [User Group]', 1, DATETIME('now'), DATETIME('now')
WHERE NOT EXISTS (SELECT 1 FROM Permission WHERE Code = 'USER_GROUP');

INSERT INTO Permission (ID, Code, Name, IsActive, CreatedOn, UpdatedOn)
SELECT 14, 'ADMINISTRATOR_ACTION', 'BiasysDB: Form [User management] -> Administrator Actions(Reset password, ..)', 1, DATETIME('now'), DATETIME('now')
WHERE NOT EXISTS (SELECT 1 FROM Permission WHERE Code = 'ADMINISTRATOR_ACTION');

INSERT INTO Permission (ID, Code, Name, IsActive, CreatedOn, UpdatedOn)
SELECT 15, 'SET_USER_IMAGE_EXPIRY_DATE', 'BiasysDB: Form [User management] -> Set user Image ad Expiry Date', 1, DATETIME('now'), DATETIME('now')
WHERE NOT EXISTS (SELECT 1 FROM Permission WHERE Code = 'SET_USER_IMAGE_EXPIRY_DATE');

INSERT INTO Permission (ID, Code, Name, IsActive, CreatedOn, UpdatedOn)
SELECT 16, 'MATERIAL_THREADS', 'BiasysDB: Form [Material Threads]', 1, DATETIME('now'), DATETIME('now')
WHERE NOT EXISTS (SELECT 1 FROM Permission WHERE Code = 'MATERIAL_THREADS');

INSERT INTO Permission (ID, Code, Name, IsActive, CreatedOn, UpdatedOn)
SELECT 17, 'SUPPLIER', 'BiasysDB: Form [Suppliers]', 1, DATETIME('now'), DATETIME('now')
WHERE NOT EXISTS (SELECT 1 FROM Permission WHERE Code = 'SUPPLIER');

INSERT INTO Permission (ID, Code, Name, IsActive, CreatedOn, UpdatedOn)
SELECT 18, 'STOCK_THREADS', 'BiasysDB: Form [Stock Threads]', 1, DATETIME('now'), DATETIME('now')
WHERE NOT EXISTS (SELECT 1 FROM Permission WHERE Code = 'STOCK_THREADS');

INSERT INTO Permission (ID, Code, Name, IsActive, CreatedOn, UpdatedOn)
SELECT 19, 'ARTICLE_GROUP', 'BiasysDB: Form [Article Group]', 1, DATETIME('now'), DATETIME('now')
WHERE NOT EXISTS (SELECT 1 FROM Permission WHERE Code = 'ARTICLE_GROUP');

INSERT INTO Permission (ID, Code, Name, IsActive, CreatedOn, UpdatedOn)
SELECT 20, 'ARTICLE_GROUP_PRINT_LABEL', 'BiasysDB: Article Group -> Print Label', 1, DATETIME('now'), DATETIME('now')
WHERE NOT EXISTS (SELECT 1 FROM Permission WHERE Code = 'ARTICLE_GROUP_PRINT_LABEL');

INSERT INTO Permission (ID, Code, Name, IsActive, CreatedOn, UpdatedOn)
SELECT 21, 'JOB_MANAGEMENT', 'BiasysDB: Job management', 1, DATETIME('now'), DATETIME('now')
WHERE NOT EXISTS (SELECT 1 FROM Permission WHERE Code = 'JOB_MANAGEMENT');

INSERT INTO Permission (ID, Code, Name, IsActive, CreatedOn, UpdatedOn)
SELECT 22, 'UNLOCK_LOCKED_ORDER', 'BiasysDB: Unlock a Locked Order', 1, DATETIME('now'), DATETIME('now')
WHERE NOT EXISTS (SELECT 1 FROM Permission WHERE Code = 'UNLOCK_LOCKED_ORDER');

INSERT INTO Permission (ID, Code, Name, IsActive, CreatedOn, UpdatedOn)
SELECT 23, 'JOB_MANAGEMENT_PRINT_LABEL', 'BiasysDB: Job management -> Print Label', 0, DATETIME('now'), DATETIME('now')
WHERE NOT EXISTS (SELECT 1 FROM Permission WHERE Code = 'JOB_MANAGEMENT_PRINT_LABEL');

INSERT INTO Permission (ID, Code, Name, IsActive, CreatedOn, UpdatedOn)
SELECT 24, 'PRODUCTION_DATA', 'BiasysDB: Form [Production Data]', 1, DATETIME('now'), DATETIME('now')
WHERE NOT EXISTS (SELECT 1 FROM Permission WHERE Code = 'PRODUCTION_DATA');

INSERT INTO Permission (ID, Code, Name, IsActive, CreatedOn, UpdatedOn)
SELECT 25, 'ARTICLE_LABEL_SCANNED_IN_BIASYSCONTROL', 'BiasysDB: Article label scanned in BiasysControl', 1, DATETIME('now'), DATETIME('now')
WHERE NOT EXISTS (SELECT 1 FROM Permission WHERE Code = 'ARTICLE_LABEL_SCANNED_IN_BIASYSCONTROL');

INSERT INTO Permission (ID, Code, Name, IsActive, CreatedOn, UpdatedOn)
SELECT 26, 'PC_SYSTEM_SETTINGS', 'BiasysDB: Form [PC System Settings]', 1, DATETIME('now'), DATETIME('now')
WHERE NOT EXISTS (SELECT 1 FROM Permission WHERE Code = 'PC_SYSTEM_SETTINGS');

INSERT INTO Permission (ID, Code, Name, IsActive, CreatedOn, UpdatedOn)
SELECT 27, 'SEWING_MACHINE_SETTING', 'BiasysDB: Form [Sewing Machine Settings]', 1, DATETIME('now'), DATETIME('now')
WHERE NOT EXISTS (SELECT 1 FROM Permission WHERE Code = 'SEWING_MACHINE_SETTING');

INSERT INTO Permission (ID, Code, Name, IsActive, CreatedOn, UpdatedOn)
SELECT 28, 'MATERIAL_FABRICS', 'BiasysDB: Form [Material Fabrics]', 1, DATETIME('now'), DATETIME('now')
WHERE NOT EXISTS (SELECT 1 FROM Permission WHERE Code = 'MATERIAL_FABRICS');

INSERT INTO Permission (ID, Code, Name, IsActive, CreatedOn, UpdatedOn)
SELECT 29, 'STOCK_FABRICS', 'BiasysDB: Form [Stock Fabrics]', 1, DATETIME('now'), DATETIME('now')
WHERE NOT EXISTS (SELECT 1 FROM Permission WHERE Code = 'STOCK_FABRICS');

INSERT INTO Permission (ID, Code, Name, IsActive, CreatedOn, UpdatedOn)
SELECT 30, 'STOCK_FABRICS_ROLLS', 'BiasysDB: Stock Fabrics -> Fabric Rolls', 0, DATETIME('now'), DATETIME('now')
WHERE NOT EXISTS (SELECT 1 FROM Permission WHERE Code = 'STOCK_FABRICS_ROLLS');

INSERT INTO Permission (ID, Code, Name, IsActive, CreatedOn, UpdatedOn)
SELECT 31, 'CUT_MATERIAL_PART', 'BiasysDB: Cutting the Material Parts', 0, DATETIME('now'), DATETIME('now')
WHERE NOT EXISTS (SELECT 1 FROM Permission WHERE Code = 'CUT_MATERIAL_PART');

INSERT INTO Permission (ID, Code, Name, IsActive, CreatedOn, UpdatedOn)
SELECT 32, 'FINAL_CHECK', 'BiasysDB: Final Check', 0, DATETIME('now'), DATETIME('now')
WHERE NOT EXISTS (SELECT 1 FROM Permission WHERE Code = 'FINAL_CHECK');

INSERT INTO Permission (ID, Code, Name, IsActive, CreatedOn, UpdatedOn)
SELECT 33, 'MISCELLANEOUS', 'BiasysDB: Miscellaneous', 0, DATETIME('now'), DATETIME('now')
WHERE NOT EXISTS (SELECT 1 FROM Permission WHERE Code = 'MISCELLANEOUS');

INSERT INTO Permission (ID, Code, Name, IsActive, CreatedOn, UpdatedOn)
SELECT 34, 'EXCEL_EXPORT_PROTOCOL', 'BiasysDB: Excel Export Protocol', 0, DATETIME('now'), DATETIME('now')
WHERE NOT EXISTS (SELECT 1 FROM Permission WHERE Code = 'EXCEL_EXPORT_PROTOCOL');

INSERT INTO Permission (ID, Code, Name, IsActive, CreatedOn, UpdatedOn)
SELECT 35, 'EXCEL_EXPORT_MISC', 'BiasysDB: Excel Export Misc. (Article, Thread, ..)', 1, DATETIME('now'), DATETIME('now')
WHERE NOT EXISTS (SELECT 1 FROM Permission WHERE Code = 'EXCEL_EXPORT_MISC');

INSERT INTO Permission (ID, Code, Name, IsActive, CreatedOn, UpdatedOn)
SELECT 36,'ADD_COMMENT_TO_PROTOCOL', 'BiasysDB: Form [Production Data] -> Add comment to Protocol', 1, DATETIME('now'), DATETIME('now')
WHERE NOT EXISTS (SELECT 1 FROM Permission WHERE Code = 'ADD_COMMENT_TO_PROTOCOL');

INSERT INTO Permission (ID, Code, Name, IsActive, CreatedOn, UpdatedOn)
SELECT 37, 'AUTOMAT_PARAMETER', 'BiasysDB: Edit Automat parameter', 1, DATETIME('now'), DATETIME('now')
WHERE NOT EXISTS (SELECT 1 FROM Permission WHERE Code = 'AUTOMAT_PARAMETER');

INSERT INTO Permission (ID, Code, Name, IsActive, CreatedOn, UpdatedOn)
SELECT 38, 'SPULEN', 'BiasysDB: Bobbins', 1, DATETIME('now'), DATETIME('now')
WHERE NOT EXISTS (SELECT 1 FROM Permission WHERE Code = 'SPULEN');

INSERT INTO Permission (ID, Code, Name, IsActive, CreatedOn, UpdatedOn)
SELECT 39, 'CHECK_SYSTEM_DATE', 'Check System Date', 1, DATETIME('now'), DATETIME('now')
WHERE NOT EXISTS (SELECT 1 FROM Permission WHERE Code = 'CHECK_SYSTEM_DATE');

INSERT INTO Permission (ID, Code, Name, IsActive, CreatedOn, UpdatedOn)
SELECT 40, 'EXTENDED_PROJECTSPECIFIC_PERMISSION1', 'extended projectspecific exec. Permission 1', 0, DATETIME('now'), DATETIME('now')
WHERE NOT EXISTS (SELECT 1 FROM Permission WHERE Code = 'EXTENDED_PROJECTSPECIFIC_PERMISSION1');

INSERT INTO Permission (ID, Code, Name, IsActive, CreatedOn, UpdatedOn)
SELECT 41, 'EXTENDED_PROJECTSPECIFIC_PERMISSION2', 'extended projectspecific exec. Permission 2', 0, DATETIME('now'), DATETIME('now')
WHERE NOT EXISTS (SELECT 1 FROM Permission WHERE Code = 'EXTENDED_PROJECTSPECIFIC_PERMISSION2');

INSERT INTO Permission (ID, Code, Name, IsActive, CreatedOn, UpdatedOn)
SELECT 42, 'EXTENDED_PROJECTSPECIFIC_PERMISSION3', 'extended projectspecific exec. Permission 3', 0, DATETIME('now'), DATETIME('now')
WHERE NOT EXISTS (SELECT 1 FROM Permission WHERE Code = 'EXTENDED_PROJECTSPECIFIC_PERMISSION3');

INSERT INTO Permission (ID, Code, Name, IsActive, CreatedOn, UpdatedOn)
SELECT 43, 'EXTENDED_PROJECTSPECIFIC_RID_PERMISSION1', 'extended projectspecific RID. permission 1', 0, DATETIME('now'), DATETIME('now')
WHERE NOT EXISTS (SELECT 1 FROM Permission WHERE Code = 'EXTENDED_PROJECTSPECIFIC_RID_PERMISSION1');

INSERT INTO Permission (ID, Code, Name, IsActive, CreatedOn, UpdatedOn)
SELECT 44, 'EXTENDED_PROJECTSPECIFIC_RID_PERMISSION2', 'extended projectspecific RID. permission 2', 0, DATETIME('now'), DATETIME('now')
WHERE NOT EXISTS (SELECT 1 FROM Permission WHERE Code = 'EXTENDED_PROJECTSPECIFIC_RID_PERMISSION2');

INSERT INTO Permission (ID, Code, Name, IsActive, CreatedOn, UpdatedOn)
SELECT 45, 'EXTENDED_PROJECTSPECIFIC_RID_PERMISSION3', 'extended projectspecific RID. permission 3', 0, DATETIME('now'), DATETIME('now')
WHERE NOT EXISTS (SELECT 1 FROM Permission WHERE Code = 'EXTENDED_PROJECTSPECIFIC_RID_PERMISSION3');

INSERT INTO Permission (ID, Code, Name, IsActive, CreatedOn, UpdatedOn)
SELECT 46, 'PRODUCTION_DATA_REPRINT_ENDLABEL', 'Form [Production Data] -> reprint endlable', 1, DATETIME('now'), DATETIME('now')
WHERE NOT EXISTS (SELECT 1 FROM Permission WHERE Code = 'PRODUCTION_DATA_REPRINT_ENDLABEL');