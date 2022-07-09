using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Word = Microsoft.Office.Interop.Word;
using System.IO;

namespace Курсовая___Страховая_компания //Класс для вывода информации на печать в .dox
{
    internal class WordHelp
    {
     
        //Объявление переменной для вывода информации в word документ
        private FileInfo _fileInfo;

        //То есть, мы можем создать через конструктор WordHelper c название файла, метод проверяет если ли такой файл
        //И его присваивает к _fileInfo 
        public WordHelp(string fileName)
        {
          //Проверяем сущутсвует ли такой файл вообще
            try
            {
                //Если существует, то переменной присвоим значение 
                if (File.Exists(fileName))
                {
                    _fileInfo = new FileInfo(fileName);
                }
            }
            catch (Exception)
            {
                //Если файл не существует
                throw new ArgumentException("File not Found");
            }
        }
        //Непосредственно процесс вывода информации на печать
        internal bool Process(Dictionary<string, string> items)
        {
            Word.Application app = null;

            try
            {
                app = new Word.Application();
                Object file = _fileInfo.FullName;

                object missing = Type.Missing;

                app.Documents.Open(file);
                foreach (var item in items)
                {
                    Word.Find find = app.Selection.Find;
                    find.Text = item.Key;
                    find.Replacement.Text = item.Value;

                    Object wrap = Word.WdFindWrap.wdFindContinue;
                    Object replace = Word.WdReplace.wdReplaceAll;

                    find.Execute(FindText: Type.Missing,
                        MatchCase: false,
                        MatchWholeWord: false,
                        MatchWildcards: false,
                        MatchSoundsLike: missing,
                        MatchAllWordForms: false,
                        Forward: true,
                        Wrap: wrap,
                        Format: false,
                        ReplaceWith: missing, Replace: replace);

                }

                Object newFileName = Path.Combine(_fileInfo.DirectoryName, DateTime.Now.ToString("yyyyMMdd HHmmss") + _fileInfo.Name);
                app.ActiveDocument.SaveAs2(newFileName);
                app.ActiveDocument.Close();
                
                return true;



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
               
            }
            finally 
            {
                if (app != null)
                app.Quit();
            }
            return false;
        }
    }
}
