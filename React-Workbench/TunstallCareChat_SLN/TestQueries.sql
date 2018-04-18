SELECT * FROM TUNApps.Admin.TCC_ConfigurationTemplates;
SELECT * FROM TUNApps.Admin.TCC_Versions;
SELECT * FROM TUNApps.Admin.TCC_Descriptors;
SELECT * FROM TUNApps.Admin.TCC_Languages;
SELECT * FROM TUNApps.Admin.TCC_Descriptors;
SELECT * FROM TUNApps.Admin.TCC_Translations;
SELECT * FROM TUNApps.Admin.TCC_Programmations;
use TUNApps
select * from Admin.TCC_Terminals;
--update admin.tcc_terminals set centreid = 1 where id = 1
SELECT * FROM pnc.dbo.ControlCentre
use TUNApps
select * from Admin.TCC_Options
SELECT * FROM TIB_CENTRE_DEF

---
SELECT [t].[Id], [t].[CentreId], [t].[Number], [t].[TemplateId], 
[t.ControlCentre].[TIB_CENTRE_DEF], 
[t.ControlCentre].[ID_CENTRE_BCK_REF], 
[t.ControlCentre].[IP], 
[t.ControlCentre].[TIB_CENTRE_NAME], 
[t.ConfigurationTemplate].[Id], 
[t.ConfigurationTemplate].[DescriptionId], 
[t.ConfigurationTemplate].[VersionId], 
[t.ConfigurationTemplate.Version].[Id], 
[t.ConfigurationTemplate.Version].[Version]
FROM [Admin].[TCC_Terminals] AS [t]
LEFT JOIN [TIB_CENTRE_DEF] AS [t.ControlCentre] 
ON [t].[CentreId] = [t.ControlCentre].[TIB_CENTRE_DEF]
LEFT JOIN [Admin].[TCC_ConfigurationTemplates] AS [t.ConfigurationTemplate] 
ON [t].[TemplateId] = [t.ConfigurationTemplate].[Id]
LEFT JOIN [Admin].[TCC_Versions] AS [t.ConfigurationTemplate.Version] 
ON [t.ConfigurationTemplate].[VersionId] = [t.ConfigurationTemplate.Version].[Id]

