﻿using System.IO;

namespace OpenEQ
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var s3d = new S3DReader("eqdata/gfaydark.s3d");
            /*foreach(var fn in s3d.Filenames) {
                var stream = s3d.Open(fn);
                var reader = new BinaryReader(stream);
                using(var fp = File.Open("s3data/" + fn, FileMode.Create)) {
                    fp.Write(reader.ReadBytes((int) stream.Length), 0, (int) stream.Length);
                }
            }*/

            var wld = new WLDReader(s3d.Open("gfaydark.wld"));
        }
    }
}