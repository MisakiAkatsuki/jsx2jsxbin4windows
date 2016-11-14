/*
 * jsx2jsxbin
 *  あかつきみさき(みくちぃP)
 * 
 * このツールについて
 *  ExtendScriptファイルのjsxをjsxbinに変換します.
 * 
 * 使用方法
 *  jsxファイルをexeと同じ階層にし,exeを実行してください.
 * 
 * 動作環境
 *  Microsoft .NET Framework 4.5(たぶん)
 *  ExtendScript Toolkit CS6,CC
 * 
 * ライセンス
 *  MIT License
 * 
 * バージョン情報
 *  2016/11/15 Ver 1.0.0 Release
*/


using System;

namespace jsx2jsxbin
{
    class jsx2jsxbin
    {
        static void Main(string[] jsxFile)
        {
            string[] baseName = { };

            string estk = @"C:\Program Files (x86)\Adobe\Adobe ExtendScript Toolkit CC\ExtendScript Toolkit.exe";


            if (System.Environment.Is64BitOperatingSystem)
            {
                estk = @"C:\Program Files (x86)\Adobe\Adobe ExtendScript Toolkit CC\ExtendScript Toolkit.exe";
                Console.WriteLine("OS : 64bit");
                // フォルダ (ディレクトリ) が存在しているかどうか確認する
                if (System.IO.File.Exists(estk))
                {
                    Console.WriteLine("CC");
                }
                else
                {
                    estk = @"C:\Program Files (x86)\Adobe\Adobe Utilities - CS6\ExtendScript Toolkit CS6\ExtendScript Toolkit.exe";
                    Console.WriteLine("CS6");
                }
            }
            else
            {
                estk = @"C:\Program Files\Adobe\Adobe ExtendScript Toolkit CC\ExtendScript Toolkit.exe";
                Console.WriteLine("OS : 32bit");
                // フォルダ (ディレクトリ) が存在しているかどうか確認する
                if (System.IO.File.Exists(estk))
                {
                    Console.WriteLine("CC");
                }
                else
                {
                    estk = @"C:\Program Files\Adobe\Adobe Utilities - CS6\ExtendScript Toolkit CS6\ExtendScript Toolkit.exe";
                    Console.WriteLine("CS6");
                }
            }

            System.Diagnostics.Process.Start(estk, @"-cmd ./jsx2jsxbin.jsx");
        }
    }
}
