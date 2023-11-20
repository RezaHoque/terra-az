namespace ToDoApi.Services
{
    public static class InitializeCosmos
    {
        public static async Task InitializeAsync(
            IConfigurationSection configurationSection)
        {
            var databaseName = configurationSection["DatabaseName"];
            var containerName = configurationSection["ContainerName"];
            var account = configurationSection["Account"];
            var key = configurationSection["Key"];

            var client = new Microsoft.Azure.Cosmos.CosmosClient(account, key);
            // Create the database if it does not exist
            DatabaseResponse database = await cosmosClient.CreateDatabaseIfNotExistsAsync(databaseName);
            Console.WriteLine(databaseName);
            Console.WriteLine(containerName);
            // Create the container if it does not exist. 
            await database.Database.CreateContainerIfNotExistsAsync(containerName, "/id");

            var cosmosDbService = new CosmosDbService(client, databaseName, containerName);
            return cosmosDbService;
        }
    }
}