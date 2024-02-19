using backend.DTOs;
using backend.Models;

namespace backend.Interfaces
{
    public interface IConfigService
    {
        Config GetConfig();

        void SetConfig(ConfigDTO config);

        bool dbConnected();
    }
}
