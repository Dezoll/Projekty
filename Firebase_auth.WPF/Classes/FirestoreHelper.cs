using Google.Cloud.Firestore;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engineer.Classes
{
    internal static class FirestoreHelper
    {

        static string fireconfig = @"
        {
         ""type"": ""service_account"",
         ""project_id"": ""inzynierka-1c21b"",
         ""private_key_id"": ""0d9c4ba8c278f2dd892b0a63b8bdc0795da90f9f"",
         ""private_key"": ""-----BEGIN PRIVATE KEY-----\nMIIEvQIBADANBgkqhkiG9w0BAQEFAASCBKcwggSjAgEAAoIBAQCwQDggZ8m+WMLd\ni3wzTXsoA10f5jFMhhl7oPwJGWI2LViWyrLql24tguAaUQkA7KqgGcq2/Uw43Zu6\nStl/BAf4yvxxOD3oWOSw66ZOyvad4k+aJhjpj1I6IkXZ8Y83fkHIswn3C8/qkirc\necD+RWVkPOlMNfmoXLmwLrClsS9jhETd8De0An7+m7Iju9LJ/faVift1iOJ4mLK3\n9ZshNWMS1D3d02KJoF7G/m3med6d6rYwx7rZ5mEGwBd8Q39Tj0B2PDqKHJIzusNX\nzjVc4CR1nJfpUNkadvZP31xEc8Auw/1H8rBCx48aXTpievl/7u/TjBb8keJCwr+H\n0aGu1wJ9AgMBAAECggEABaD3aemGouKYzpR+0fCeh0ecOMGUP3pk4/LfObcq0Mof\n8yjkD+PoK+HrIEwIOpRUWqqYM8HhJkvFhmyPh6PsUUDCUSdXqszz+MZ92DRZLe+l\nVSn0T7k5CgxAKNazGTWaCjvVjKM+76HdZo8o37X9p/beCIYMxBi6AWtsTs5a0hXA\ntMqdZXe3T09QMbxKHqtRSQeBFELF67Yry61L8VZYPOn8YIdwd3MFLZLjSmbxj+bJ\nqiWFv+INdft7EfhPt5R7mQAU3x58Cm/nguiLxiFncU9Ky9dYh0MZF43P+P05n/VI\nZ9uhCfc5sQ39FqEjzNVxx9vt92kvR9QYMmU3jbiv4QKBgQDmJxuRZq/aekLreDSv\nVT0mhlbobK716Er5GUpw3gsoEKYJ6EkmI3N6Q6HazSWBfFrXicbtVHpfc9TXPR/J\nwW587Oi+nSqvyV8TrkTbj+DqTRSo/BeNgDnnndnS0JvdKKDtJU8ghj3+bCtzlkXF\nTLh7lfiIuT7SaCQevgttZz+IxQKBgQDEC25+6EdqyEa8BduNQusjbx5EmZCi/p5E\nVzoSlBnFMKHArYU4vk2YfAPK1oSufOL5FHMtfKO9ExwMFh4+VFXysKCtzfTM5eaE\nYvSJDY5ijnMgkbd6AcKznXwdmOE60mj7M+F21ZQ/jZN8mcmEMhT805EhfE23yZKE\nG22n/qn+WQKBgBb+yU5ZyDA4Dv+f3wO1rIpw2bYXRdPkBbmlwT5NsSeroitTPhvF\nZwBMSZum65xoZFsstOd5jVCELjvjK43o+bUZppeE9ILjx9AblV2qnnpKgUnxBhlp\nOl/d8amSlkAekxWeqK1DPGZzQFQoK4hvBe+zKEXg3FoBdbpsmo+vxTVRAoGAMT/t\n8lPIHTtTCcku7r3w9GXl5LXvcAMnH2QKYsBx+OfOuujcnvSv6a6+BSb/DhaxroFE\nrhixyb4TPbYQwvfM37sfooorBY576qYxaHzPWFMQ+Q2iWjQ3BYh6tbTCYFSbqv/N\nlFzzcUPP2W2JAnzSaPF9dDwWCiXJeQaq9Zk0e4ECgYEAne/lqoJD8f41OMaTgaLF\ncn6ZDURiu1CduIDT4Hviw+0yhyfWDL5q32MSD5yqSv2Wp/zFHSQZz86p8TDemzLk\njtpdYlYaW4ADFPUJnJpMqwCW5sBtV5P3DaIqQGa4vbobFzS1f+x+i8XTmmk2IwGM\nkCcsnSfvUbaodsCAoGC0SpM=\n-----END PRIVATE KEY-----\n"",
         ""client_email"": ""firebase-adminsdk-afbik@inzynierka-1c21b.iam.gserviceaccount.com"",
         ""client_id"": ""108926765702442214369"",
         ""auth_uri"": ""https://accounts.google.com/o/oauth2/auth"",
         ""token_uri"": ""https://oauth2.googleapis.com/token"",
         ""auth_provider_x509_cert_url"": ""https://www.googleapis.com/oauth2/v1/certs"",
         ""client_x509_cert_url"": ""https://www.googleapis.com/robot/v1/metadata/x509/firebase-adminsdk-afbik%40inzynierka-1c21b.iam.gserviceaccount.com"",
         ""universe_domain"": ""googleapis.com""
        }";

        static string filepath = "";
        public static FirestoreDb Database { get; private set; }
        public static void SetEnvironmentVariable()
        {
            //generowane w users/temp folder
            filepath = Path.Combine(Path.GetTempPath(), Path.GetFileNameWithoutExtension(Path.GetRandomFileName())) + ".json";
            File.WriteAllText(filepath, fireconfig);
            File.SetAttributes(filepath, FileAttributes.Hidden);
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", filepath);
            Database = FirestoreDb.Create("inzynierka-1c21b");
            File.Delete(filepath);  
        }
    }
}
