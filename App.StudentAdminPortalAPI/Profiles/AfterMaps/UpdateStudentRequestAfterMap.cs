﻿using App.StudentAdminPortalAPI.DomainModels;
using AutoMapper;

namespace App.StudentAdminPortalAPI.Profiles.AfterMaps
{
    public class UpdateStudentRequestAfterMap : IMappingAction<UpdateStudentRequest, DataModels.Student>
    {
        public void Process(UpdateStudentRequest source, DataModels.Student destination, ResolutionContext context)
        {
            destination.Address = new DataModels.Address()
            {
                PhysicalAddress = source.PhysicalAddress,
                PostalAddress = source.PostalAddress
            };
        }
    }
}