using Box.V2.Config;
using Box.V2.JWTAuth;
using Box.V2.Models;
namespace FoodDeliveryManagement
{
    class BoxAPI
    {
        //The access token obtained from Box Developer Console
        private static string developerToken = "Nd3RGNiuEZh5PZn2sJ6y2V6kqmKwzcDN";

        //Upload File To Box
        public async Task<string> UploadFileToBox(string fileName)
        {
            try
            {
                string clientId = "3k7cpryp7oed24pzh0eu6chfxftn3nbs";
                string clientSecret = "cRpnaSXpxPHr86kLL7E7mvBUKpNorki7";
                var boxConfig = new BoxConfig(clientId, clientSecret, new Uri("http://localhost"));
                var boxJWTAuth = new BoxJWTAuth(boxConfig);
                var boxClient = boxJWTAuth.AdminClient(developerToken);
                using (var stream = new FileStream(fileName, FileMode.Open))
                {
                    var fileRequest = new BoxFileRequest
                    {
                        Name = Path.GetFileName(fileName),
                        Parent = new BoxRequestEntity { Id = "0", Type = BoxType.file },
                    };

                    //Uploading file
                    var uplaodedFile = await boxClient.FilesManager.UploadAsync(fileRequest, stream);
                    return "file uploaded - FileId: " + uplaodedFile.Id;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
                return "file failed to upload";
            }
        }

        //Download File From Box by fileId
        public async Task<string> DownloadFileFromBox(string fileID)
        {
            try
            {
                string clientId = "3k7cpryp7oed24pzh0eu6chfxftn3nbs";
                string clientSecret = "cRpnaSXpxPHr86kLL7E7mvBUKpNorki7";
                var boxConfig = new BoxConfig(clientId, clientSecret, new Uri("http://localhost"));
                var boxJWTAuth = new BoxJWTAuth(boxConfig);
                var boxClient = boxJWTAuth.AdminClient(developerToken);

                //File info loading
                BoxFile fileInfo = await boxClient.FilesManager.GetInformationAsync(id: fileID);

                //Geting file stream
                Stream fileContents = await boxClient.FilesManager.DownloadAsync(id: fileID);


                //Specify the local path where you want to save the downloaded file
                string localPath = System.Reflection.Assembly.GetExecutingAssembly().Location;
                localPath = Path.GetDirectoryName(localPath);
                string subPath = localPath + @"\Downloads";

                //Creating a new download folder
                try
                {
                    if (!Directory.Exists(subPath)) { DirectoryInfo di = Directory.CreateDirectory(subPath); }
                }
                catch (IOException ioex)
                {
                    Console.WriteLine(ioex.Message);
                }

                //Copying/Downloading file to local folder
                using (var fileStream = File.Create(subPath + @"\" + fileInfo.Name))
                {
                    fileContents.CopyTo(fileStream);

                }
                return "file downloaded to the location\n" + subPath + @"\" + fileInfo.Name;
            }
            catch (Exception)
            {
                return "file failed to download";
            }

        }
    }
}
