using System.IO;

namespace ChallengeCase
{
    public class FileManager
    {
        private string directoryPath;
        private string fileName;
        private string fullPathName;

        public FileManager(string directoryPath, string fileName) {
            this.directoryPath = directoryPath;
            this.fileName = fileName;
        }

        public string GetFileName()
        {
            this.fullPathName = GetPathString();
            var newFileName = Path.Combine(this.fullPathName, this.fileName);

            if (File.Exists(newFileName))
            {
                File.Delete(newFileName);
            }

            return newFileName;
        }

        public string GetPathString()
        {
            this.fullPathName = Path.Combine(this.directoryPath, Parameter.NEW_FOLDER_NAME);
            if (!Directory.Exists(this.fullPathName))
            {
                Directory.CreateDirectory(this.fullPathName);
            }

            return this.fullPathName;
        }
    }
}
