using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace InsuranceCompany.Class
{
    public class FileReader
    {
        private FileInfo _fileInfo;

        public void FileRead(string fileName, ComboBox comboBox)
        {
            //Метод для чтения информации из текстового файла
            _fileInfo = new FileInfo(fileName);
            string[] text = System.IO.File.ReadAllLines(fileName);
            comboBox.Items.AddRange(text);
            
        }
    }
}
