/*
Add SewingMachineConfiguration use for Sewing Machine
*/
INSERT INTO SewingMachineConfiguration (MachineNumber, AlternativeMachine, ActivatedFootLiftinCriticalSection, MaxNoStitchesPerNeedles, ClipSensorActivationName, OnAfterMinStitchesminusXStitch, StitchesAlreadySewn, CSAStitches, ETMLastAdjusted, IsActive, CreatedOn, UpdatedOn)
SELECT 1, 2, 1, 20000, "Alway ON", 5, 0, 0, 365, 1, DATETIME('now'), DATETIME('now')
WHERE NOT EXISTS (SELECT 1 FROM SewingMachineConfiguration WHERE MachineNumber = 1 AND AlternativeMachine=2);