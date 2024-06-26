﻿using CodeBE_LEM.Entities;

namespace CodeBE_LEM.Controllers.AppUserController
{
    public class AppUser_AppUserClassroomMappingDTO
    {
        public long Id { get; set; }

        public long ClassroomId { get; set; }

        public long AppUserId { get; set; }

        public long? RoleId { get; set; }

        public AppUser_RoleDTO? Role { get; set; }

        public AppUser_AppUserClassroomMappingDTO() { }
        public AppUser_AppUserClassroomMappingDTO(AppUserClassroomMapping AppUserClassroomMapping)
        {
            Id = AppUserClassroomMapping.Id;
            ClassroomId = AppUserClassroomMapping.ClassroomId;
            AppUserId = AppUserClassroomMapping.AppUserId;
            RoleId = AppUserClassroomMapping.RoleId;
            Role = AppUserClassroomMapping.Role == null ? null : new AppUser_RoleDTO(AppUserClassroomMapping.Role);
        }
    }
}
