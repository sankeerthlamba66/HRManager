namespace HRManager.Code
{
    public class FileManager
    {
        public static string UploadProfile(IFormFile Document, string UploadFolderPath)
        {
            string uniqueFileName = string.Empty;
            string filePath = string.Empty;

            if (Document != null)
            {
                uniqueFileName = Guid.NewGuid().ToString() + "_" + Document.FileName;
                filePath = Path.Combine(UploadFolderPath, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    Document.CopyTo(fileStream);
                }
            }

            return filePath;
        }
    }
}
