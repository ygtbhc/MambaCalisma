using System.Collections.Generic;

namespace MessageHelperLibrary
{
    public static class SqlScriptMessage
    {
        public const string _fileName = @"C:\Users\yigit\Documents\Visual Studio 2017\Projects\MambaCalisma\MessageHelperLibrary\XmlFiles\ScriptErrorMessage.xml";

        public const string _xpath = @"//Message[@name]";

        public static Dictionary<string, string> MessageBase = XmlMessageBase.GetValue(_fileName, _xpath);

        public static string DatabaseNameErrorMessage()
        {
            return MessageBase["CheckDatabaseName"];
        }

        public static string CheckSchemaNameErrorMessage()
        {
            return MessageBase["CheckSchemaName"];
        }
        public static string CheckMambaType()
        {
            return MessageBase["CheckMambaType"];
        }

    }
}
