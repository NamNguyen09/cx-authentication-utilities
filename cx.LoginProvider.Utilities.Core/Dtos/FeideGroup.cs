﻿namespace cx.LoginProvider.Utilities.Core.Dtos
{
    [Serializable]
    public partial class FeideGroup
    {
        public string Id { get; set; }
        public string DisplayName { get; set; }
        public List<string> OrgType { get; set; }
        public string NorEduOrgNIN { get; set; }
    }
}
