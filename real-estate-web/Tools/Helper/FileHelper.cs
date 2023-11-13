

namespace real_estate_web.Tools.Helper
{
    public static class FileHelper
    {
        public static string RootDirectory = Path.Combine(Environment.CurrentDirectory, "wwwroot");

        public static string Add(IFormFile file)
        {
            var sourcepath = Path.GetTempFileName();
            if (file.Length > 0)
            {
                using (var stream = new FileStream(sourcepath, FileMode.Create))
                {
                    file.CopyTo(stream);
                }
            }
            var result = newPath(file);
            if (!HasFile(Path.Combine(RootDirectory, result)))
            {
                File.Move(sourcepath, @"wwwroot" + result);
            }
            return result;
        }

        public static string Add(IFormFile file, string subDirectoryName)
        {
            var sourcepath = Path.GetTempFileName();
            if (file.Length > 0)
            {
                using (var stream = new FileStream(sourcepath, FileMode.Create))
                {
                    file.CopyTo(stream);
                }
            }
            var result = newSubDirectoryPath(file, subDirectoryName);
            File.Move(sourcepath, @"wwwroot" + result);
       
            return result;
        }

        public static bool HasFile(string directory, string fileName)
        {
            return File.Exists(Path.Combine(directory, fileName));
        }

        public static bool HasFile(string fullPath)
        {
            return File.Exists(fullPath);
        }

        public static async Task<List<string>> AddAllAsync(List<IFormFile> files, string subDirectoryName)
        {
            var sourcepath = Path.GetTempFileName();
            List<string> results = new List<string>();
            if (files.Count > 0)
            {
                foreach (var file in files)
                {
                    using (var stream = new FileStream(sourcepath, FileMode.Create))
                    {
                        await file.CopyToAsync(stream);
                    }
                    var result = newSubDirectoryPath(file, subDirectoryName);
                    if (!HasFile(Path.Combine(RootDirectory, result)))
                    {
                        File.Move(sourcepath, @"wwwroot" + result);
                    }
                    else
                    {
                        File.Delete(sourcepath);
                    }
                    results.Add(result);
                }
            }
            return results;
        }
        public static void Delete(string path)
        {
            if (path.StartsWith(Path.DirectorySeparatorChar) || path.StartsWith(Path.AltDirectorySeparatorChar))
            {
                path = path.TrimStart(Path.DirectorySeparatorChar).TrimStart(Path.AltDirectorySeparatorChar);
            }
            var fullpath = Path.Combine(RootDirectory, path);
            File.Delete(fullpath);
        }
        public static string Update(string oldSourcePath, IFormFile file)
        {
            var sourcePath = Path.GetTempFileName();
            if (file.Length > 0)
            {
                using (var stream = new FileStream(sourcePath, FileMode.Create))
                {
                    file.CopyTo(stream);
                }
            }
            var result = newPath(file);
            File.Move(sourcePath, @"wwwroot" + result);
            File.Delete(Environment.CurrentDirectory + @"/wwwroot" + oldSourcePath);
            return result;
        }

        public static string Update(string oldSourcePath, IFormFile file, string subDirectoryName)
        {
            var sourcePath = Path.GetTempFileName();
            if (file.Length > 0)
            {
                using (var stream = new FileStream(sourcePath, FileMode.Create))
                {
                    file.CopyTo(stream);
                }
            }
            var result = newSubDirectoryPath(file, subDirectoryName);
            File.Move(sourcePath, @"wwwroot" + result);
            File.Delete(Environment.CurrentDirectory + @"/wwwroot" + oldSourcePath);
            return result;
        }

        public static string newPath(IFormFile file)
        {
            //FileInfo ff = new FileInfo(file.FileName);
            //string fileExtension = ff.Extension;

            string path = @"/upload-images"; //Environment.CurrentDirectory +
            //var newPath = Guid.NewGuid().ToString() + "_" + DateTime.Now.Month + "_" + DateTime.Now.Day + "_" + DateTime.Now.Year + fileExtension;
            string newPath = file.FileName;

            string result = $@"{path}/{newPath}";
            return result;
        }

        public static string newSubDirectoryPath(IFormFile file, string subDirectoryName)
        {
            //FileInfo ff = new FileInfo(file.FileName);
            //string fileExtension = ff.Extension;

            string path = $@"/upload-images/{subDirectoryName}";
            if (!Directory.Exists($@"{Environment.CurrentDirectory}/wwwroot{path}"))
            {
                Directory.CreateDirectory($@"{Environment.CurrentDirectory}/wwwroot{path}");
            }
            //var newPath = Guid.NewGuid().ToString() + "_" + DateTime.Now.Month + "_" + DateTime.Now.Day + "_" + DateTime.Now.Year + fileExtension;
            var newPath = file.FileName;

            string result = $@"{path}/{newPath}";
            return result;
        }
    }
}