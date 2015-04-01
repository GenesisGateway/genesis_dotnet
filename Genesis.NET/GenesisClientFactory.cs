namespace Genesis.Net
{
    public static class GenesisClientFactory
    {
        public static IGenesisClient Create(Configuration configuration)
        {
            return new GenesisClient(configuration);
        }
    }
}
