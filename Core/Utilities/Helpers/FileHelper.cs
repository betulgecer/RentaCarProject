﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Core.Utilities.Helpers
{
    public class FileHelper
    {
        static string directory = Directory.GetCurrentDirectory() + @"\wwwroot\";
        static string path = @"Images\";

        public static string Add(IFormFile file)
        {
            string extension = Path.GetExtension(file.FileName);
            string newFileName = Guid.NewGuid().ToString("N") + extension;

            if (!Directory.Exists(directory + path))
            {
                Directory.CreateDirectory(directory + path);
            }

            using (FileStream fileStream = File.Create(directory + path + newFileName))
            {
                file.CopyTo(fileStream);
                fileStream.Flush();
            }


            return (path + newFileName).Replace("\\", "/");
        }



        public static void Delete(string imagePath)
        {
            if (File.Exists(directory + imagePath.Replace("/", "\\")) && Path.GetFileName(imagePath) != "Logo.png")
            {
                File.Delete(directory + imagePath.Replace("/", "\\"));
            }
        }


        public static string Update(IFormFile file, string oldImagePath)
        {
            Delete(oldImagePath);
            return Add(file);


        }


    }
}
