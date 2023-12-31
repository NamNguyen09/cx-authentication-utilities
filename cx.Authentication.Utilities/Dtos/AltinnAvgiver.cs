﻿using System;

namespace cx.Authentication.Utilities.Dtos
{
    [Serializable]
    public partial class AltinnAvgiver
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string OrganizationNumber { get; set; }
        public string ParentOrganizationNumber { get; set; }
        public string OrganizationForm { get; set; }
        public string Status { get; set; }
        public string SocialSecurityNumber { get; set; }
    }
}