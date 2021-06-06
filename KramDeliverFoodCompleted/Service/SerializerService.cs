﻿using KramDeliverFoodCompleted.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace KramDeliverFoodCompleted.Service
{
    public class SerializerService : ISerializerService
    {
        public void DoSerialization<T>(T input) where T : class
        {
            var folderName = "Data";
            var fileName = typeof(T).Name + ".txt";
            var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, folderName, fileName);
            var result = JsonSerializer.Serialize(input);
            using var file = new StreamWriter(path, true);
            file.WriteLine(result);
        }

        public IList<T> DoDeserialization<T>() where T : class
        {
            var folderName = "Data";
            var fileName = typeof(T).Name + ".txt";
            var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, folderName, fileName);
            var data = new List<T>();

            if (File.Exists(path))
            { 
                var items = File.ReadAllLines(path).ToList();

                foreach (var item in items)
                {
                    data.Add(JsonSerializer.Deserialize<T>(item));
                }

                return data;
            }

            return default;
        }
    }
}
