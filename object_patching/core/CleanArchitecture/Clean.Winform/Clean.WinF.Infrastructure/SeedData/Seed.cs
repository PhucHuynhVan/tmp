using Clean.WinF.Applications.Features.Language.DTOs;
using Clean.WinF.Applications.Features.Language.Interfaces;
using Clean.WinF.Applications.Features.Menu.DTOs;
using Clean.WinF.Applications.Features.Menu.Interfaces;
using Clean.WinF.Applications.Features.Users.DTOs;
using Clean.WinF.Applications.Features.Users.Interfaces;
using Clean.WinF.Infrastructure.DBContext;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Serilog;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace Clean.WinF.Infrastructure.SeedData
{
    public class Seed
    {
        private readonly IMenuQueryServices _menuQueryServices;
        private readonly IMenuCommandServices _menuCommandServices;

        private readonly ILanguageQueryServices _languageQueryService;
        private readonly ILanguageCommandServices _languageCommandService;

        private readonly IUserQueryServices _userQueryServices;
        private readonly IUserCommandServices _userCommandService;

        private readonly IUserGroupQueryServices _userGroupQueryServices;
        private readonly IUserGroupCommandServices _userGroupCommandService;

        public Seed(
            IMenuQueryServices menuQueryServices,
            IMenuCommandServices menuCommandService,
            ILanguageQueryServices languageQueryService,
            ILanguageCommandServices languageCommandServices,
            IUserQueryServices userQueryServices,
            IUserCommandServices userCommandService,
            IUserGroupQueryServices userGroupQueryServices,
            IUserGroupCommandServices userGroupCommandService)
        {
            _menuQueryServices = menuQueryServices;
            _menuCommandServices = menuCommandService;
            _languageQueryService = languageQueryService;
            _languageCommandService = languageCommandServices;
            _userQueryServices = userQueryServices;
            _userCommandService = userCommandService;
            _userGroupQueryServices = userGroupQueryServices;
            _userGroupCommandService = userGroupCommandService;
        }

        public void InitialSeedData(bool isRunningTest)
        {
            var jsonData = LoadDataFromJson(isRunningTest);
            var languages = new List<LanguageDto>();
            var menus = new List<MenuDto>();
            var users = new List<string>();
            var userGroups = new List<string>();

            if (!_languageQueryService.GetAllLanguages("en").Result.Any())
            {
                //languages first
                foreach (var item in jsonData.Languages)
                {
                    languages.Add(item);
                }
                var result = _languageCommandService.CreateBulkLanguages(languages).Result;
                if (!result)
                {
                    Log.Error("Initialize execution languages");
                }
            }

            var currMenus = _menuQueryServices.GetAllMenus("en").Result;
            if (currMenus is null || currMenus.Count == 0)
            {
                //menu first
                foreach (var item in jsonData.Menus)
                {
                    menus.Add(item);
                }
                var result = _menuCommandServices.CreateBulkMenus(menus).Result;
                if (!result)
                {
                    Log.Error("Initialize execution menus error please check again");
                }
            }

            //custom to execute sql script also
            InitializeDataFromSQLScript();
        }

        private SeedModel LoadDataFromJson(bool isRunningTest)
        {
            var seedModel = new SeedModel();
            string assemblyPath = Assembly.GetExecutingAssembly().Location;
            string assemblyDirectory = Path.GetDirectoryName(assemblyPath);

            //languages
            if (File.Exists(Path.Combine(assemblyDirectory, @"SeedData\Languages.json")))
            {
                if (File.ReadAllText(Path.Combine(assemblyDirectory, @"SeedData\Languages.json")) != null
                && File.ReadAllText(Path.Combine(assemblyDirectory, @"SeedData\Languages.json")).Any())
                {
                    seedModel.Languages = JsonConvert.DeserializeObject<List<LanguageDto>>(File.ReadAllText(Path.Combine(assemblyDirectory, @"SeedData\Languages.json")));
                }
            }

            //menus
            if (File.Exists(Path.Combine(assemblyDirectory, @"SeedData\Menus.json")))
            {
                if (File.ReadAllText(Path.Combine(assemblyDirectory, @"SeedData\Menus.json")) != null
                && File.ReadAllText(Path.Combine(assemblyDirectory, @"SeedData\Menus.json")).Any())
                {
                    seedModel.Menus = JsonConvert.DeserializeObject<List<MenuDto>>(File.ReadAllText(Path.Combine(assemblyDirectory, @"SeedData\Menus.json")));
                }
            }

            return seedModel;
        }

        private void InitializeDataFromSQLScript()
        {
            string assemblyPath = Assembly.GetExecutingAssembly().Location;
            string assemblyDirectory = Path.GetDirectoryName(assemblyPath);
            string script = string.Empty;
            var relativePath = string.Empty;
            //permission first
            if (File.Exists(Path.Combine(assemblyDirectory, @"Scripts\Initial_Data_For_Permission.sql")))
            {
                relativePath = Path.Combine(assemblyDirectory, @"Scripts\Initial_Data_For_Permission.sql");
                script = System.IO.File.ReadAllText(relativePath);
                using (var context = new ApplicationDBContext())
                {
                    context.Database.ExecuteSqlRaw(script);
                }
            }

            //role
            if (File.Exists(Path.Combine(assemblyDirectory, @"Scripts\Initial_Data_For_Role.sql")))
            {
                relativePath = Path.Combine(assemblyDirectory, @"Scripts\Initial_Data_For_Role.sql");
                script = System.IO.File.ReadAllText(relativePath);
                using (var context = new ApplicationDBContext())
                {
                    context.Database.ExecuteSqlRaw(script);
                }
            }

            //role
            if (File.Exists(Path.Combine(assemblyDirectory, @"Scripts\Initial_Data_For_System_Configuration.sql")))
            {
                relativePath = Path.Combine(assemblyDirectory, @"Scripts\Initial_Data_For_System_Configuration.sql");
                script = System.IO.File.ReadAllText(relativePath);
                using (var context = new ApplicationDBContext())
                {
                    context.Database.ExecuteSqlRaw(script);
                }
            }

            //computer
            if (File.Exists(Path.Combine(assemblyDirectory, @"Scripts\Initial_Data_For_Computer.sql")))
            {
                relativePath = Path.Combine(assemblyDirectory, @"Scripts\Initial_Data_For_Computer.sql");
                script = System.IO.File.ReadAllText(relativePath);
                script = string.Format(script, Environment.MachineName, Environment.MachineName);
                using (var context = new ApplicationDBContext())
                {
                    context.Database.ExecuteSqlRaw(script);
                }
            }

            //user
            if (File.Exists(Path.Combine(assemblyDirectory, @"Scripts\Initial_Data_For_User.sql")))
            {
                relativePath = Path.Combine(assemblyDirectory, @"Scripts\Initial_Data_For_User.sql");
                script = System.IO.File.ReadAllText(relativePath);
                using (var context = new ApplicationDBContext())
                {
                    context.Database.ExecuteSqlRaw(script);
                }
            }

            //user group
            if (File.Exists(Path.Combine(assemblyDirectory, @"Scripts\Initial_Data_For_UserGroup.sql")))
            {
                relativePath = Path.Combine(assemblyDirectory, @"Scripts\Initial_Data_For_UserGroup.sql");
                script = System.IO.File.ReadAllText(relativePath);
                using (var context = new ApplicationDBContext())
                {
                    context.Database.ExecuteSqlRaw(script);
                }
            }
            //ClipSenSorActivation use for Sewing Machine
            if (File.Exists(Path.Combine(assemblyDirectory, @"Scripts\Initial_Data_For_ClipSenSorActivation.sql")))
            {
                relativePath = Path.Combine(assemblyDirectory, @"Scripts\Initial_Data_For_ClipSenSorActivation.sql");
                script = System.IO.File.ReadAllText(relativePath);
                using (var context = new ApplicationDBContext())
                {
                    context.Database.ExecuteSqlRaw(script);
                }
            }
            //ConnectedDevice use for Sewing Machine
            if (File.Exists(Path.Combine(assemblyDirectory, @"Scripts\Initial_Data_For_ConnectedDevice.sql")))
            {
                relativePath = Path.Combine(assemblyDirectory, @"Scripts\Initial_Data_For_ConnectedDevice.sql");
                script = System.IO.File.ReadAllText(relativePath);
                using (var context = new ApplicationDBContext())
                {
                    context.Database.ExecuteSqlRaw(script);
                }
            }
            //DeviceRouting use for Sewing Machine
            if (File.Exists(Path.Combine(assemblyDirectory, @"Scripts\Initial_Data_For_DeviceRouting.sql")))
            {
                relativePath = Path.Combine(assemblyDirectory, @"Scripts\Initial_Data_For_DeviceRouting.sql");
                script = System.IO.File.ReadAllText(relativePath);
                using (var context = new ApplicationDBContext())
                {
                    context.Database.ExecuteSqlRaw(script);
                }
            }
            //DeviceType use for Sewing Machine
            if (File.Exists(Path.Combine(assemblyDirectory, @"Scripts\Initial_Data_For_DeviceType.sql")))
            {
                relativePath = Path.Combine(assemblyDirectory, @"Scripts\Initial_Data_For_DeviceType.sql");
                script = System.IO.File.ReadAllText(relativePath);
                using (var context = new ApplicationDBContext())
                {
                    context.Database.ExecuteSqlRaw(script);
                }
            }
            //Port use for Sewing Machine
            if (File.Exists(Path.Combine(assemblyDirectory, @"Scripts\Initial_Data_For_Port.sql")))
            {
                relativePath = Path.Combine(assemblyDirectory, @"Scripts\Initial_Data_For_Port.sql");
                script = System.IO.File.ReadAllText(relativePath);
                using (var context = new ApplicationDBContext())
                {
                    context.Database.ExecuteSqlRaw(script);
                }
            }
            //SewingMachineConfiguration use for Sewing Machine
            if (File.Exists(Path.Combine(assemblyDirectory, @"Scripts\Initial_Data_For_SewingMachineConfiguration.sql")))
            {
                relativePath = Path.Combine(assemblyDirectory, @"Scripts\Initial_Data_For_SewingMachineConfiguration.sql");
                script = System.IO.File.ReadAllText(relativePath);
                using (var context = new ApplicationDBContext())
                {
                    context.Database.ExecuteSqlRaw(script);
                }
            }

        }
    }

    public class SeedModel
    {
        public List<LanguageDto> Languages { get; set; } = new List<LanguageDto>();
        public List<MenuDto> Menus { get; set; } = new List<MenuDto>();
        public List<UserDto> Users { get; set; } = new List<UserDto>();
        public List<UserGroupDto> UserGroups { get; set; } = new List<UserGroupDto>();
        public List<PermissionDto> Permissions { get; set; } = new List<PermissionDto>();
    }
}
