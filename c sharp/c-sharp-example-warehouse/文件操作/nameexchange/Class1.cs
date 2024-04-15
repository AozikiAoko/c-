using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
namespace nameexchange
{
    public class Exchange//改名模块
    {
        public static void Exchange_0(string Yourfile,string Newfile, List<FileInfo> isfiles)//载入要改名字的文件和要改的名以及放入文件信息的泛型集合
        {
            for (int i = 0; i < isfiles.Count; i++)
            { 
                bool ishave = isfiles[i].Name.Contains( Yourfile); //判断文件集合中是否存在你输入的文件
                if (ishave) 
                {
                   string secFileName = isfiles[i].Name;
                    string destFileName = isfiles[i].Directory.FullName +Newfile+ isfiles[i].Extension;
                    File.Move(secFileName, destFileName);
                }
            }
        }
        
    }
}
