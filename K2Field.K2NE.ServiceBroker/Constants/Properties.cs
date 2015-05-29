﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace K2Field.K2NE.ServiceBroker.Constants
{
    public  static partial class Properties
    {
            public static class ErrorLog
            {
                public const string Profile = "Profile";
                public const string ProcessInstanceId = "ProcessInstanceId";
                public const string ProcessName = "ProcessDefinitionName";
                public const string Folio = "Folio";
                public const string ErrorDescription = "ErrorDescription";
                public const string ErrorItem = "ErrorItem";
                public const string ErrorId = "ErrorId";
                public const string ErrorDate = "ErrorDate";
                public const string TryNewVersion = "TryNewVersion";
            }



            public static class ManagementWorklist
            {
                public const string ActivityId = "ActivityId";
                public const string ActivityInstanceDestinationId = "ActivityInstanceDestinationId";
                public const string ActivityInstanceId = "ActivityInstanceId";
                public const string ActivityName = "ActivityName";
                public const string Destination = "Destination";
                public const string DestinationType = "DestinationType";
                public const string EventId = "EventId";
                public const string Folio = "Folio";
                public const string ProcessInstanceId = "ProcessInstanceId";
                public const string EventName = "EventName";
                public const string ProcessName = "ProcessName";
                public const string ProcessStatus = "ProcessStatus";
                public const string StartDate = "StartDate";
                public const string WorklistItemStatus = "Status";
                public const string WorklistItemId = "Id";
                public const string FromUser = "FromUser";
                public const string ToUser = "ToUser";
            }

            public static class ClientWorklist
            {
                public const string ProcessName = "ProcessName";
                public const string ProcessFolder = "Folder";
                public const string ProcessFullname = "ProcessFullname";
                public const string ProcessDescription = "ProcessDescription";
                public const string ProcessMetadata = "PocessMetadata";
                public const string ProcessStatus = "ProcessStatus";
                public const string ProcessPriority = "ProcessPriority";
                public const string ProcessStartdate = "ProcessStartDate";
                public const string ProcessExpectedDuration = "ProcessExpectedDuration";
                public const string ProcessGuid = "ProcessGuid";
                public const string ProcessId = "ProcessId";
                public const string ActivityId = "ActivityId";
                public const string ActivityName = "ActivityName";
                public const string ActivityPriority = "ActivityPriority";
                public const string ActivityDescription = "ActivityDescription";
                public const string ActivityMetadata = "ActivityMetadata";
                public const string ActivityStartdate = "ActivityStartDate";
                public const string ActivityExpectedDuration = "ActivityExpectedDuration";
                public const string EventId = "EventId";
                public const string EventName = "EventName";
                public const string EventMetadata = "EventMetadata";
                public const string EventDescription = "EventDescription";
                public const string EventPriority = "EventPriority";
                public const string EventStartDate = "EventStartDate";
                public const string EventExpectedDuration = "EventExpectedDuration";
                public const string WorklistItemStatus = "Status";
                public const string Folio = "Folio";
                public const string Data = "Data";
                public const string SerialNumber = "SerialNumber";
                public const string ActivityOverdue = "ActivityOverdue";
                public const string OriginalDestination = "OriginalDestination";
                public const string IncludeShared = "IncludeShared";
                public const string ExcludeAllocated = "ExcludeAllocated";
            }


            public static class Role
            {
                public const string RoleName = "RoleName";
                public const string RoleItemType = "ItemType";
                public const string RoleExclude = "Excluded";
                public const string RoleItem = "RoleItem";
                public const string RoleDescription = "Description";
                public const string RoleDynamic = "IsDynamic";
            }

            public static class Identity
            {
                public const string CurrentPrincipalAuthType = "CurrentPrincipalAuthType =";
                public const string CurrentPrincipalName = "CurrentPrincipalName";
                public const string FQN = "FQN";
                public const string UserDescription = "UserDescription";
                public const string UserDisplayName = "UserDisplayName";
                public const string UserEmail = "UserEmail";
                public const string UserManager = "UserManager";
                public const string UserName = "UserName";
                public const string UserUserLabel = "UserUserLabel";
                public const string CallingFQN = "CallingFQN";
                public const string WindowsIdentityAuthType = "WindowsIdentityAuthType";
                public const string WindowsIdentityName = "WindowsIdentityName";
                public const string ServiceBrokerAuthType = "ServiceBrokerAuthType";
                public const string ServiceBrokerUserName = "ServiceBrokerUserName";
                public const string UserWindowsImpersonation = "UserWindowsImpersonation";
            }

            public static class ProcessInstanceManagement
            {
                public const string ActivityName = "ActivityName";
                public const string ProcessInstanceId = "ProcessInstanceId";
                public const string ProcessName = "ProcessName";
                public const string StartSync = "StartSynchronous";
                public const string ProcessFolio = "Folio";
                public const string ProcessVersion = "ProcessVersion";
            }

            public static class ActiveDirectory
            {
                public const string SamAccountName = "sAMAcountName";
                public const string DisplayName = "DisplayName";
                public const string CommonName = "CommonName";
                public const string UserFQN = "UserFQN";
                public const string GivenName = "GivenName";
                public const string Initials = "Initials";
                public const string Surname = "Surname";
                public const string Email = "Email";

                public const string SubStringSearchInput = "SubStringSearchInput";
                public const string OrganisationalUnit = "OrganisationalUnit";


                public static string MaxSearchResultSize = "MaxResultSize";

            }

            public static class WorkingHoursConfiguration
            {
                public const string ZoneName = "ZoneName";
                public const string NewZoneName = "NewZoneName";
                public const string ZoneGUID = "ZoneGUID";
                public const string Description = "Description";
                public const string GMTOffset = "GMTOffset";
                public const string DefaultZone = "DefaultZone";
                
                public const string DurationHours = "DurationHours";
                public const string DurationMinutes = "DurationMinutes";
                public const string DurationSeconds = "DurationSeconds";
                public const string TimeOfDayHours = "TimeOfDayHours";
                public const string TimeOfDayMinutes = "TimeOfDayMinutes";
                public const string TimeOfDaySeconds = "TimeOfDaySeconds";
                public const string WorkDay = "WorkDay";
                
                //public const string Description = "Description";
                //public const string AvailabilityDateDurationDays = "AvailabilityHoursTimeOfDayDays";
                //public const string AvailabilityDateDurationHours = "AvailabilityDateDurationHours";
                //public const string AvailabilityDateDurationMinutes = "AvailabilityDateDurationMinutes";
                //public const string AvailabilityDateDurationSeconds = "AvailabilityDateDurationSeconds";
                public const string IsNonWorkDate = "IsNonWorkDate";
                //public const string AvailabilityDateTimeOfDayHours = "AvailabilityDateTimeOfDayHours";
                //public const string AvailabilityDateTimeOfDayMinutes = "AvailabilityDateTimeOfDayMinutes";
                //public const string AvailabilityDateTimeOfDaySeconds = "AvailabilityDateTimeOfDaySeconds";
                public const string WorkDate = "WorkDate";
                public const string FQN = "FQN";
                public const string UserName = "UserName";
                public const string ZoneExists = "ZoneExists";
                public const string StartDateTime = "StartDateTime";
                public const string FinishDateTime = "FinishDateTime";
            }

            public static class OutOfOffice
            {
                public const string UserFQN = "UserFQN";
                public const string UserStatus = "UserStatus";
                public const string CallSuccess = "CallSuccess";
                public const string DestinationUser = "DestinationUser";

            }
    }
}
