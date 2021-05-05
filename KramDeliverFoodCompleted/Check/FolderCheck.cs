using System.IO;

namespace KramDeliverFoodCompleted.Check
{
    public class FolderCheck
    {
        public static void FolderExist(string path)
        {
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);
        }
    }
}
