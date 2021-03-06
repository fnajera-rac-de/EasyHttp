﻿using System.IO;

namespace EasyHttp.Infrastructure
{
    public class FileData : MultiPartFileDataAbstraction
    {
        public string Filename { get; set; }

        public override Stream GetStream()
        {
            return new FileStream(Filename, FileMode.Open, FileAccess.Read);
        }

        public override long GetLength()
        {
            return new FileInfo(Filename).Length;
        }

        public override string GetFilenameForDisposition()
        {
            return Path.GetFileName(Filename);
        }
    }
}