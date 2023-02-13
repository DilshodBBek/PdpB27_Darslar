using System.Xml;
using System.Xml.Serialization;

namespace _3_Modul.Lesson_6_JSON_XML.XML_Sample.Crud_USER_Service
{
    internal static class XML_CRUD_Users_Service
    {
        static string Path_Users_Database = @"..\..\..\Lesson_6_JSON_XML\XML_Sample\Crud_USER_Service\Users_Database\UsersDatabase.xml";
        readonly static XmlSerializer serializer = new XmlSerializer(typeof(List<User>));
        readonly static XmlDocument xml_Db = new();
        //static XML_CRUD_Users_Service()
        //{
        //    if (!File.Exists(Path_Users_Database))
        //    {
        //        xml_Db.Load(Path_Users_Database);
        //    }
        //}

        public static int AddUsers(List<User> users)
        {
            int CountAddedElemnts = 0;
            if (!File.Exists(Path_Users_Database))
            {
                using StreamWriter sw = File.CreateText(Path_Users_Database);
                serializer.Serialize(sw, users);
            }
            else
            {
                xml_Db.Load(Path_Users_Database);
                XmlElement? root = xml_Db.DocumentElement;
                using MemoryStream ms = new();
                serializer.Serialize(ms, users);
                ms.Position = 0;
                XmlDocument? Xml_UsersList = new();
                Xml_UsersList.Load(ms);
                XmlElement? usersRoot = Xml_UsersList.DocumentElement;
                XmlNode importedNodes = xml_Db.ImportNode(usersRoot, true);
                XmlNodeList allUsers = importedNodes.ChildNodes;
                foreach (XmlNode node in allUsers)
                {
                    string OuterXml = node.FirstChild.OuterXml;
                    bool isFind = File.ReadAllText(Path_Users_Database).Contains(OuterXml);
                    if (!isFind)
                    {
                        root.AppendChild(node);
                        xml_Db.Save(Path_Users_Database);
                        CountAddedElemnts++;
                    }
                }
            }
            return CountAddedElemnts;
        }
        public static void AddUser(User user)
        {
            AddUsers(new List<User>() { user });
        }

        public static List<User> GetAllUsers()
        {
            List<User>? users = new();
            using (StreamReader fs = new(Path_Users_Database))
            {
                users = serializer.Deserialize(fs) as List<User>;
            }
            return users ?? new();
        }
        public static void Delete(User user)
        {
            xml_Db.Load(Path_Users_Database);
            XmlNode? foundUser = xml_Db.SelectSingleNode(@$"/ArrayOfUser/User[Id={user.Id} and Name='{user.Name}']");

            foundUser?.ParentNode?.RemoveChild(foundUser);
            xml_Db.Save(Path_Users_Database);
        }
        public static bool Update(int Id, User user)
        {
            xml_Db.Load(Path_Users_Database);
            XmlNode? foundUser = xml_Db.SelectSingleNode(@$"/ArrayOfUser/User[Id={Id}]");
            foundUser.SelectSingleNode("Id").InnerText = user.Id.ToString();
            foundUser.SelectSingleNode("Name").InnerText = user.Name;
            xml_Db.Save(Path_Users_Database);
            return true;
        }

    }
}

