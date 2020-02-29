using System;

namespace SysFin.Services.Services
{
    public static class GuidService
    {
        public static string NovoGuid()
        {
            return Guid.NewGuid().ToString().Replace("-", "").Substring(0, 20).ToUpper();
        }
    }
}
