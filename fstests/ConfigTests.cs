namespace fstests;

using backend.DTOs;
using backend.Models;
using backend.Services;
using FluentAssertions;

public class ConfigTests
{
    [Fact]
    public void UpdatedConfig()
    {
        ConfigService configService = new ConfigService();
        ConfigDTO configDTO = new ConfigDTO
        {
            dbHost = "localhost",
            dbName = "formsphere",
            dbPassword = "formsphere",
            dbUsername = "formsphere",
            timezoneId = "Etc/UTC"
        };


        configService.SetConfig(configDTO);
        Config newConfig = configService.GetConfig();
        newConfig.dbHost.Should().Be("localhost");

    }

}