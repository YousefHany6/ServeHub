using ServeHub.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServeHub.Domain.Entities
{
    public class SystemSetting:BaseEntity
    {
        public string arabicName { get; set; }
        public string SettingKey { get; set; }
        public string SettingValue { get; set; }

    }
}
