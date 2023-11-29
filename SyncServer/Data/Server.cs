namespace SyncServer.Data
{
    public class Server
    {
        public string ServerName { get; set; }
        public string PortNumber { get; set; }
        public string UserID { get; set; }
        public string Password { get; set; }

        public Server(string serverName,string portNumber,string userID,string password)
        {
            ServerName = serverName;
            PortNumber = portNumber;
            UserID = userID;
            Password = password;
        }
        public Server() { } 
        public Server(string connection)
        {
            string[] connectionArray=connection.Split(",");
            ServerName = connectionArray[0];    
            PortNumber = connectionArray[1];
            UserID = connectionArray[2];
            Password = connectionArray[3];
        }
    }
}
