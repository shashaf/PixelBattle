namespace Common
{
    public static class ClientCommands
    {
        public const string CreateWorld = "CREATE";
        public const string JoinWorld = "JOIN";
        public const string PlacePixel = "PIXEL";
        public const string ListWorlds = "LIST";
    }

    public static class ServerCommands
    {
        public const string WorldState = "STATE";
        public const string PixelPlaced = "PIXEL_OK";
        public const string Error = "ERROR";
        public const string WorldList = "WORLDS";

    }
}
