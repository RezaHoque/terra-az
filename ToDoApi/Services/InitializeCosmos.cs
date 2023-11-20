using Microsoft.Azure.Cosmos;

namespace ToDoApi.Services
{
    public static class InitializeCosmos
    {
        public static async Task<CosmosClient> InitializeCosmosClientInstanceAsyn(
            IConfigurationSection configurationSection)
        {
            var databaseName = configurationSection["DatabaseName"];
            var containerName = configurationSection["ContainerName"];
            var account = configurationSection["Account"];
            var key = configurationSection["Key"];

            var client = new Microsoft.Azure.Cosmos.CosmosClient(account, key);
            
            return client;
           
        }
    }
}