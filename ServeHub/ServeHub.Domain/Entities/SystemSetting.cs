using ServeHub.Domain.Entities.Common;

namespace ServeHub.Domain.Entities
{
    public class SystemSetting:BaseEntity
    {
        public string arabicName { get; private set; }
        public string SettingKey { get; private set; }
        public string SettingValue { get; private set; }

    }
}
