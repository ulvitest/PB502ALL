using CollectionsReflectionFile.Lesson.Models;
using Newtonsoft.Json;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace CollectionsReflectionFile.Lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Collections,Reflection,DirectoryInfo,FileInfo,FileStream,StreamWriter,StreamReader

            #region collections
            //Console.WriteLine("Hello, World!");
            //Stack stack = new Stack();//LIFO
            //stack.Push(20);
            //stack.Push(2);
            //stack.Push(true);
            //stack.Push("lorem");
            //stack.Pop();
            //stack.Contains(20);
            //object o=stack.Peek();
            //foreach (var item in stack)
            //{
            //    Console.WriteLine(item);
            //}
            //Stack<int> stack = new Stack<int>();
            //stack.Push(1);
            //stack.Push(2);
            //stack.Push("");
            //Stack<Student>stack = new Stack<Student>();
            //stack.Push(new(1, "Lorem"));

            //Queue<string> queue = new Queue<string>();//FIFO
            //queue.Enqueue("Rasim");
            //queue.Enqueue("Samir");
            //queue.Enqueue("Ramil");

            //queue.Dequeue();
            //Console.WriteLine(queue.Peek());

            //foreach (var item in queue)
            //{
            //    Console.WriteLine(item);
            //}

            //SortedList sortedList = new SortedList();
            //sortedList.Add(1, "Yusif");
            //sortedList.Add(6, "Kamran");
            //sortedList.Add(3, "Asif");
            //sortedList.Clear()

            //foreach (DictionaryEntry item in sortedList)
            //    Console.WriteLine(item.Key+" "+item.Value);
            //SortedList<int, string> sortedList = new();

            //Hashtable hashtable = new Hashtable();
            //hashtable.Add("first", new Student(1, "Lorem"));
            //hashtable.Add("second", new Student(1, "Lorem"));
            //if (!hashtable.ContainsKey("first"))
            //    hashtable.Add("first", "");
            //Console.WriteLine(hashtable.Count);

            //foreach (DictionaryEntry student in hashtable)
            //    Console.WriteLine(student.Key+" "+student.Value);

            //Dictionary<List<int>,bool>dic = new Dictionary<List<int>,bool>();
            //dic.Add(new List<int>() { 20,11},true);
            //Dictionary<string,string>dictionary = new Dictionary<string,string>();
            //dictionary.Add("first", "+99451");
            //dictionary.Add("second", "+99451");
            //dictionary.Add("third", "+99451");
            //if (dictionary.ContainsKey("firstt"))
            //{
            //    Console.WriteLine(dictionary["firstt"]);
            //}
            //foreach (KeyValuePair<string,string> item in dictionary)
            //{
            //    Console.WriteLine(item.Value);
            //}
            #endregion
            #region reflection
            //Student student = new(1, "lorem");
            //Console.WriteLine(student.GetType());

            //int num = 12;
            //Console.WriteLine(num.GetType());
            //Type type=typeof(Student);
            //Console.WriteLine(type.IsPublic);
            //Console.WriteLine(type.IsSealed);
            //Console.WriteLine(type.Name);
            //Console.WriteLine(type.FullName);

            //FieldInfo[] fields = type.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
            //foreach (var field in fields)
            //{
            //    Console.WriteLine(field.Name+" "+field.GetValue(student));
            //}
            //PropertyInfo[] props=type.GetProperties();
            //foreach (var item in props)
            //{
            //    Console.WriteLine(item.Name);
            //}

            //var methods=type.GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly);
            //foreach (var item in methods)
            //{
            //    Console.WriteLine(item);
            //}
            //var ctors=type.GetConstructors();
            //foreach (var ctor in ctors)
            //{
            //    foreach (var item in ctor.GetParameters())
            //    {

            //    }
            //}

            //Assembly assembly = Assembly.GetExecutingAssembly();
            //foreach (var item in assembly.GetModules())
            //{
            //    Console.WriteLine(item.Name);
            //}
            //Type type = typeof(Student);
            //object instance = Activator.CreateInstance(type);

            //PropertyInfo prop = type.GetProperty("Id");

            //// Set the value of the given property on the given instance
            //prop.SetValue(instance, 12, null);

            //// at this stage instance.Bar will equal to the value
            //Console.WriteLine(((Student)instance).Id);

            #endregion
            #region fileDirectory

            //string path = @"C:\Users\USER\Desktop\PB502\";

            //DirectoryInfo directoryInfo = new DirectoryInfo(path);
            //Console.WriteLine(directoryInfo.Name);
            //Console.WriteLine(directoryInfo.FullName);
            //Console.WriteLine(directoryInfo.Root);
            //Console.WriteLine(directoryInfo.LastAccessTime);
            //Console.WriteLine(directoryInfo.LastWriteTime);
            //Console.WriteLine(directoryInfo.CreationTime);


            //FileInfo[] fileInfos = directoryInfo.GetFiles();

            //foreach (var file in fileInfos)
            //{
            //    Console.WriteLine(file.Name);
            //    Console.WriteLine(file.FullName);
            //    Console.WriteLine(file.LastAccessTime);
            //    Console.WriteLine(file.LastWriteTime);
            //    Console.WriteLine(file.CreationTime);
            //}
            //FileInfo file = new FileInfo(path);
            //Console.WriteLine(file.Name);
            //Console.WriteLine(file.FullName);
            //Console.WriteLine(file.LastAccessTime);
            //Console.WriteLine(file.LastWriteTime);
            //Console.WriteLine(file.CreationTime);

            //if (!Directory.Exists(path))
            //    Directory.CreateDirectory(path);
            //if (File.Exists(path))
            //    File.Delete(path);
            //Directory.Delete(path, true);

            //string path = @"C:\Users\USER\Desktop\PB502\CollectionsReflectionFile\CollectionsReflectionFile.Lesson\Data\Dir1\file1.txt";

            //FileStream fileStream = new FileStream(path, FileMode.Append);
            //StreamWriter writer = new StreamWriter(fileStream);
            //writer.WriteLine("salam");
            //writer.Close();
            //fileStream.Close();


            //directive statement
            //using FileStream fileStream = new FileStream(path, FileMode.Open);
            //using StreamReader reader = new StreamReader(fileStream);
            //var data = reader.ReadToEnd();
            //Console.WriteLine(data);
            #endregion
            //Student student = new Student() { Id = 1, Name = "Lorem Ipsum" };
            //SerializeWithXml(student);
            //Console.WriteLine(DeSerializeWithXml());
            //SerializeWithJson(student);
            //Console.WriteLine(DeSerializeWithJson());
            //Console.WriteLine(DeserializeFromFile());
            foreach (var item in DeserializeFromFileList())
                Console.WriteLine(item);
            //ReadDataWithHttpClient();
        }
        public static void SerializeWithJson(Student student)
        {
           using FileStream fileStream = new FileStream("C:\\Users\\USER\\Desktop\\PB502\\CollectionsReflectionFile\\CollectionsReflectionFile.Lesson\\Data\\student.json", FileMode.Open);
            string result = JsonConvert.SerializeObject(student);
           using  StreamWriter streamWriter = new StreamWriter(fileStream);
            streamWriter.Write(result);
        }
        public static Student DeSerializeWithJson()
        {
            using FileStream fileStream = new FileStream("C:\\Users\\USER\\Desktop\\PB502\\CollectionsReflectionFile\\CollectionsReflectionFile.Lesson\\Data\\student.json", FileMode.Open);
            using StreamReader streamReader = new StreamReader(fileStream);
            string result = streamReader.ReadToEnd();
            return JsonSerializer.Deserialize<Student>(result);

        }

        public static void SerializeWithXml(Student student)
        {
            FileStream fs = new FileStream("C:\\Users\\USER\\Desktop\\PB502\\CollectionsReflectionFile\\CollectionsReflectionFile.Lesson\\Data\\student.xml", FileMode.Open);
            XmlSerializer serializer = new XmlSerializer(typeof(Student));
            serializer.Serialize(fs, student);

        }
        public static Student DeSerializeWithXml()
        {

            FileStream fs = new FileStream("C:\\Users\\USER\\Desktop\\PB502\\CollectionsReflectionFile\\CollectionsReflectionFile.Lesson\\Data\\student.xml", FileMode.Open);
            XmlSerializer serializer = new XmlSerializer(typeof(Student));
            Student obj= serializer.Deserialize(fs) as Student;
            return obj;
        }

        public static User DeserializeFromFile()
        {

            using FileStream fileStream = new FileStream("C:\\Users\\USER\\Desktop\\PB502\\CollectionsReflectionFile\\CollectionsReflectionFile.Lesson\\Data\\fakeData.json", FileMode.Open);
            using StreamReader streamReader = new StreamReader(fileStream);
            string result = streamReader.ReadToEnd();
            return JsonSerializer.Deserialize<User>(result);
        }
        public static List<User> DeserializeFromFileList()
        {

            using FileStream fileStream = new FileStream("C:\\Users\\USER\\Desktop\\PB502\\CollectionsReflectionFile\\CollectionsReflectionFile.Lesson\\Data\\fakeData.json", FileMode.Open);
            using StreamReader streamReader = new StreamReader(fileStream);
            string result = streamReader.ReadToEnd();
            return JsonConvert.DeserializeObject<List<User>>(result);
        }

        public static void ReadDataWithHttpClient()
        {
            HttpClient client = new HttpClient();
            var data = client.GetAsync("https://jsonplaceholder.typicode.com/users").GetAwaiter().GetResult();
            var stringResult=data.Content.ReadAsStringAsync().Result;

            using FileStream fileStream = new FileStream("C:\\Users\\USER\\Desktop\\PB502\\CollectionsReflectionFile\\CollectionsReflectionFile.Lesson\\Data\\fakeData.json", FileMode.Open);
            using StreamWriter streamWriter = new StreamWriter(fileStream);
            streamWriter.Write(stringResult);
        }

    }
}
