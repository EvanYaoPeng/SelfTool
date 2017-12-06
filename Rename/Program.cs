using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rename
{
    class Program
    {
        static void Main(string[] args)
        {
            DetleteFile(@"D:\SelfTest\SelfTools\MvcTools\Templates\");
            //MoveFileToNew(@"D:\learn\1709\", @"D:\learn\170901\rpfile\");
            //DirectoryInfo di = new DirectoryInfo(@"D:\learn\1709\");
            //int idx = 0;

            //foreach (FileInfo fi in di.GetFiles())//可以用 di.GetFiles("*.jpg") 只重名jpg文件
            //{
            //    if (fi.Name.Contains(".rp"))
            //    {
            //        //File.Move(fi.FullName, @"D:\learn\170901\rpfile\"+fi.Name);
            //        File.Copy(fi.FullName, @"D:\learn\170901\rpfile\" + fi.Name);
            //    }
            //    ////确定是增加前缀，还是后缀
            //    //string toFileName = fi.Name.Split('.')[0] + "Service";
            //    ////if (fi.Name.StartsWith("希赛软件设计师视频教程"))
            //    ////{

            //    ////}
            //    ////执行重命名
            //    //fi.MoveTo(Path.Combine(fi.DirectoryName, toFileName + fi.Extension));

            //    idx++;
            //}
        }

        /// <summary>
        /// 移动某一文件夹下面所有的文件类型为.rp的 文件到保存文件夹中 
        /// </summary>
        /// <param name="sourcePatch"></param>
        /// <param name="savePath"></param>
        /// <returns></returns>
        public static bool MoveFileToNew(string sourcePatch, string savePath)
        {
            //if (!Directory.Exists(savePath))
            //{
            //    Directory.CreateDirectory(savePath);
            //}

            #region
            try
            {
                string[] labDirs = Directory.GetDirectories(sourcePatch);//目录
                string[] labFiles = Directory.GetFiles(sourcePatch);//文件
                if (labFiles.Length > 0)
                {
                    for (int i = 0; i < labFiles.Length; i++)
                    {
                        if (labFiles[i].ToString().Contains(".rp"))//排除.lab文件
                        {
                            File.Move(sourcePatch + "\\" + Path.GetFileName(labFiles[i]), @"D:\learn\170901\rpfile\" + Path.GetFileName(labFiles[i]));
                        }
                    }
                }
                if (labDirs.Length > 0)
                {
                    for (int j = 0; j < labDirs.Length; j++)
                    {
                        Directory.GetDirectories(sourcePatch + "\\" + Path.GetFileName(labDirs[j]));

                        //递归调用
                        MoveFileToNew(sourcePatch + "\\" + Path.GetFileName(labDirs[j]), savePath + "\\" + Path.GetFileName(labDirs[j]));
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
            #endregion
            return true;
        }


        public static bool DetleteFile(string sourcePatch)
        {
            try
            {
                string[] labDirs = Directory.GetDirectories(sourcePatch);//目录
                string[] labFiles = Directory.GetFiles(sourcePatch);//文件
                if (labFiles.Length > 0)
                {
                    for (int i = 0; i < labFiles.Length; i++)
                    {
                        if (labFiles[i].ToString().Contains(".vb.t4"))//排除.lab文件
                        {
                            File.Delete(sourcePatch + "\\" + Path.GetFileName(labFiles[i]));//.Move(sourcePatch + "\\" + Path.GetFileName(labFiles[i]), @"D:\learn\170901\rpfile\" + Path.GetFileName(labFiles[i]));
                        }
                    }
                }
                if (labDirs.Length > 0)
                {
                    for (int j = 0; j < labDirs.Length; j++)
                    {
                        Directory.GetDirectories(sourcePatch + "\\" + Path.GetFileName(labDirs[j]));

                        //递归调用
                        DetleteFile(sourcePatch + "\\" + Path.GetFileName(labDirs[j]));
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// 拷贝oldlab的文件到newlab下面
        /// </summary>
        /// <param name="sourcePath">lab文件所在目录(@"~\labs\oldlab")</param>
        /// <param name="savePath">保存的目标目录(@"~\labs\newlab")</param>
        /// <returns>返回:true-拷贝成功;false:拷贝失败</returns>
        public bool CopyOldLabFilesToNewLab(string sourcePath, string savePath)
        {
            if (!Directory.Exists(savePath))
            {
                Directory.CreateDirectory(savePath);
            }

            #region //拷贝labs文件夹到savePath下
            try
            {
                string[] labDirs = Directory.GetDirectories(sourcePath);//目录
                string[] labFiles = Directory.GetFiles(sourcePath);//文件
                if (labFiles.Length > 0)
                {
                    for (int i = 0; i < labFiles.Length; i++)
                    {
                        if (Path.GetFileName(labFiles[i]) != ".lab")//排除.lab文件
                        {
                            File.Copy(sourcePath + "\\" + Path.GetFileName(labFiles[i]), savePath + "\\" + Path.GetFileName(labFiles[i]), true);
                        }
                    }
                }
                if (labDirs.Length > 0)
                {
                    for (int j = 0; j < labDirs.Length; j++)
                    {
                        Directory.GetDirectories(sourcePath + "\\" + Path.GetFileName(labDirs[j]));

                        //递归调用
                        CopyOldLabFilesToNewLab(sourcePath + "\\" + Path.GetFileName(labDirs[j]), savePath + "\\" + Path.GetFileName(labDirs[j]));
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
            #endregion
            return true;
        }
    }
}
