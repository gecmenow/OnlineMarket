using KramDeliverFoodCompleted.Interfaces;
using System;
using System.IO;

namespace KramDeliverFoodCompleted.Service
{
    public class LoggerService : ILoggerService
    {
        private const string folderName = "Data";

        public void AddLog(string input)
        {
            var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, folderName);

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            var fileName = "Log " + DateTime.Now.Date.ToShortDateString() + ".txt";
            path = Path.Combine(path, fileName);

            using var file = new StreamWriter(path, true);
            file.WriteLine(input);
        }
    }
}
