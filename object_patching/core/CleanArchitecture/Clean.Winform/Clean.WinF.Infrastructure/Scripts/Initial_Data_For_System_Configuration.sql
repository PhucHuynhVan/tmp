/*
Configuration for BiasysDB
*/
INSERT INTO SystemConfiguration (FeatureKey, Permission)
SELECT 'db_form_articles','1'
WHERE NOT EXISTS (SELECT 1 FROM SystemConfiguration WHERE FeatureKey = 'db_form_articles');

INSERT INTO SystemConfiguration (FeatureKey, Permission)
SELECT 'db_form_material_threads','1'
WHERE NOT EXISTS (SELECT 1 FROM SystemConfiguration WHERE FeatureKey = 'db_form_material_threads');

INSERT INTO SystemConfiguration (FeatureKey, Permission)
SELECT 'db_form_material_fabrics','1'
WHERE NOT EXISTS (SELECT 1 FROM SystemConfiguration WHERE FeatureKey = 'db_form_material_fabrics');

INSERT INTO SystemConfiguration (FeatureKey, Permission)
SELECT 'db_form_stock_threads','1'
WHERE NOT EXISTS (SELECT 1 FROM SystemConfiguration WHERE FeatureKey = 'db_form_stock_threads');

INSERT INTO SystemConfiguration (FeatureKey, Permission)
SELECT 'db_form_stock_fabrics','1'
WHERE NOT EXISTS (SELECT 1 FROM SystemConfiguration WHERE FeatureKey = 'db_form_stock_fabrics');

INSERT INTO SystemConfiguration (FeatureKey, Permission)
SELECT 'db_form_fabric_roll','0'
WHERE NOT EXISTS (SELECT 1 FROM SystemConfiguration WHERE FeatureKey = 'db_form_fabric_roll');

INSERT INTO SystemConfiguration (FeatureKey, Permission)
SELECT 'db_form_user_management','1'
WHERE NOT EXISTS (SELECT 1 FROM SystemConfiguration WHERE FeatureKey = 'db_form_user_management');

INSERT INTO SystemConfiguration (FeatureKey, Permission)
SELECT 'db_form_usergroup_permission','1'
WHERE NOT EXISTS (SELECT 1 FROM SystemConfiguration WHERE FeatureKey = 'db_form_usergroup_permission');

INSERT INTO SystemConfiguration (FeatureKey, Permission)
SELECT 'db_form_machine_computer_configuration','1'
WHERE NOT EXISTS (SELECT 1 FROM SystemConfiguration WHERE FeatureKey = 'db_form_machine_computer_configuration');

INSERT INTO SystemConfiguration (FeatureKey, Permission)
SELECT 'db_form_bobbin','0'
WHERE NOT EXISTS (SELECT 1 FROM SystemConfiguration WHERE FeatureKey = 'db_form_bobbin');

INSERT INTO SystemConfiguration (FeatureKey, Permission)
SELECT 'db_form_job_management','0'
WHERE NOT EXISTS (SELECT 1 FROM SystemConfiguration WHERE FeatureKey = 'db_form_job_management');

INSERT INTO SystemConfiguration (FeatureKey, Permission)
SELECT 'db_articlelabel_scanned_with_biasyscontrol','0'
WHERE NOT EXISTS (SELECT 1 FROM SystemConfiguration WHERE FeatureKey = 'db_articlelabel_scanned_with_biasyscontrol');

INSERT INTO SystemConfiguration (FeatureKey, Permission)
SELECT 'db_project_specific_data','0'
WHERE NOT EXISTS (SELECT 1 FROM SystemConfiguration WHERE FeatureKey = 'db_project_specific_data');

INSERT INTO SystemConfiguration (FeatureKey, Permission)
SELECT 'db_production_data','0'
WHERE NOT EXISTS (SELECT 1 FROM SystemConfiguration WHERE FeatureKey = 'db_production_data');

INSERT INTO SystemConfiguration (FeatureKey, Permission)
SELECT 'db_miscellaneous_show_and_printreport','0'
WHERE NOT EXISTS (SELECT 1 FROM SystemConfiguration WHERE FeatureKey = 'db_miscellaneous_show_and_printreport');

INSERT INTO SystemConfiguration (FeatureKey, Permission)
SELECT 'db_miscellaneous_automat_configuration','0'
WHERE NOT EXISTS (SELECT 1 FROM SystemConfiguration WHERE FeatureKey = 'db_miscellaneous_automat_configuration');

INSERT INTO SystemConfiguration (FeatureKey, Permission)
SELECT 'db_miscellaneous_sab_configuration','0'
WHERE NOT EXISTS (SELECT 1 FROM SystemConfiguration WHERE FeatureKey = 'db_miscellaneous_sab_configuration');

INSERT INTO SystemConfiguration (FeatureKey, Permission)
SELECT 'db_language','English'
WHERE NOT EXISTS (SELECT 1 FROM SystemConfiguration WHERE FeatureKey = 'db_language');

INSERT INTO SystemConfiguration (FeatureKey, Permission)
SELECT 'db_archieve_all_protocol_after_days','7'
WHERE NOT EXISTS (SELECT 1 FROM SystemConfiguration WHERE FeatureKey = 'db_archieve_all_protocol_after_days');

INSERT INTO SystemConfiguration (FeatureKey, Permission)
SELECT 'db_directory_archived_protocol','C:\\Protocol'
WHERE NOT EXISTS (SELECT 1 FROM SystemConfiguration WHERE FeatureKey = 'db_directory_archived_protocol');

INSERT INTO SystemConfiguration (FeatureKey, Permission)
SELECT 'db_directory_of_protocol_files_written_by_biasyscontrol','C:\\Protocol\BiasysControl'
WHERE NOT EXISTS (SELECT 1 FROM SystemConfiguration WHERE FeatureKey = 'db_directory_of_protocol_files_written_by_biasyscontrol');

/*
Configuration for BiasysControl
*/
INSERT INTO SystemConfiguration (FeatureKey, Permission)
SELECT 'ct_logon_at_program_start','1'
WHERE NOT EXISTS (SELECT 1 FROM SystemConfiguration WHERE FeatureKey = 'ct_logon_at_program_start');

INSERT INTO SystemConfiguration (FeatureKey, Permission)
SELECT 'ct_language','English'
WHERE NOT EXISTS (SELECT 1 FROM SystemConfiguration WHERE FeatureKey = 'ct_language');


/*
Genernal Configuration (For both BiasysControl and BiasysDB)
*/
INSERT INTO SystemConfiguration (FeatureKey, Permission)
SELECT 'general_interface_barcode_printer','COM 2'
WHERE NOT EXISTS (SELECT 1 FROM SystemConfiguration WHERE FeatureKey = 'general_interface_barcode_printer');

INSERT INTO SystemConfiguration (FeatureKey, Permission)
SELECT 'general_logon_with_barcode_handheld_scanner_and_user_card','1'
WHERE NOT EXISTS (SELECT 1 FROM SystemConfiguration WHERE FeatureKey = 'general_logon_with_barcode_handheld_scanner_and_user_card');

INSERT INTO SystemConfiguration (FeatureKey, Permission)
SELECT 'general_directory_and_filename_of_sab_backup_application','C:\\Backup'
WHERE NOT EXISTS (SELECT 1 FROM SystemConfiguration WHERE FeatureKey = 'general_directory_and_filename_of_sab_backup_application');

INSERT INTO SystemConfiguration (FeatureKey, Permission)
SELECT 'general_maxtime_span_between_program_end_start_indays','7'
WHERE NOT EXISTS (SELECT 1 FROM SystemConfiguration WHERE FeatureKey = 'general_maxtime_span_between_program_end_start_indays');
