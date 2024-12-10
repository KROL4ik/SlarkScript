using IKDTematika.Models.ApiModels;
using System.Net.Http.Json;
namespace MokrousScript.Script
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            //Scaffold-DbContext "Host=pg3.sweb.ru;Port=5432;Database=maxmokmail_ikd2;Username=maxmokmail_ikd2;Password=FGKhT3967V#FHBF8" Npgsql.EntityFrameworkCore.PostgreSQL
            using (var db = new MaxmokmailIkd2Context())
            {
                var courses = db.Courses.ToList();
                foreach (var course in courses)
                {
                    var httpClient = new HttpClient();
                    var requestModel = new RequestModel();
                    Console.WriteLine(course.Name);

                    var idCourse = course.Id;

                    requestModel.Subject = course.Name;
                    requestModel.Link = "aboba.ru";
                    var uri = @"https://localhost:7299/api/ikdtematika/themes";
                    var jsonString = Newtonsoft.Json.JsonConvert.SerializeObject(requestModel);
                    HttpContent content = JsonContent.Create(requestModel);
                 
                    using var response = await httpClient.PostAsync(uri, content);

                    string responseText = await response.Content.ReadAsStringAsync();
                    var responceModel = Newtonsoft.Json.JsonConvert.DeserializeObject<ResponceModel>(responseText);
                    int index = 0;
                    foreach (var e in responceModel.disciplineSubjects.Themes)
                    {
                        index++;
                        Console.WriteLine(e);
                    }
                    //db.Add
                    Console.WriteLine();
                    break;

                }
            }
        }
    }
}
