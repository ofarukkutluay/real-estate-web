

namespace real_estate_web.Tools.Helper
{
    public class FileHelper
    {
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
            File.Move(sourcepath, @"wwwroot" + result);
            return result;
        }

        public static async Task<List<string>> AddAllAsync(List<IFormFile> files,string subDirectoryName)
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
                    var result = newMultiplePath(file,subDirectoryName);
                    File.Move(sourcepath, @"wwwroot" + result);
                    results.Add(result);
                }
            }
            return results;
        }
        public static void Delete(string path)
        {
            File.Delete(Environment.CurrentDirectory + @"\wwwroot" + path);
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
            File.Delete(Environment.CurrentDirectory + @"\wwwroot" + oldSourcePath);
            return result;
        }
        public static string newPath(IFormFile file)
        {
            FileInfo ff = new FileInfo(file.FileName);
            string fileExtension = ff.Extension;

            string path =  @"\upload-images"; //Environment.CurrentDirectory +
            var newPath = Guid.NewGuid().ToString() + "_" + DateTime.Now.Month + "_" + DateTime.Now.Day + "_" + DateTime.Now.Year + fileExtension;

            string result = $@"{path}\{newPath}";
            return result;
        }

        public static string newMultiplePath(IFormFile file,string subDirectoryName)
        {
            FileInfo ff = new FileInfo(file.FileName);
            string fileExtension = ff.Extension;
            
            string path =  $@"\upload-images\{subDirectoryName}"; 
            if(!Directory.Exists($@"{Environment.CurrentDirectory}\wwwroot{path}")){
                Directory.CreateDirectory($@"{Environment.CurrentDirectory}\wwwroot{path}");
            }
            var newPath = Guid.NewGuid().ToString() + "_" + DateTime.Now.Month + "_" + DateTime.Now.Day + "_" + DateTime.Now.Year + fileExtension;

            string result = $@"{path}\{newPath}";
            return result;
        }
    }
}