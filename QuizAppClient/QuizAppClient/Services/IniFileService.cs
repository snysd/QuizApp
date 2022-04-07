using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IniParser;
using IniParser.Model;

namespace QuizAppClient.Services
{
    class IniFileService
    {
        public IniData iniData;

        public IniFileService(string iniFilePath)
        {
            ReadIniFile(iniFilePath);
        }

        public void ReadIniFile(string iniFilePath)
        {
            var parser = new FileIniDataParser();
            if(File.Exists(iniFilePath)) iniData = parser.ReadFile(iniFilePath);
        }
    }
}
