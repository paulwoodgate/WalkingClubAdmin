using System;
using System.IO;

namespace ReportGen
{
    public class ConvertOptions
    {
        public bool ConvertFolder { get; set; }
        public string FileName { get; set; }
        public string FolderPath { get; set; }
        public string OutputPath { get; set; }

        public void Validate()
        {
            if (string.IsNullOrWhiteSpace(OutputPath))
            {
                throw new ArgumentException("An output folder must be supplied");
            }

            if (!Path.Exists(OutputPath))
            {
                throw new ArgumentException($"The output folder \"{OutputPath}\" does not exist");
            }

            if (ConvertFolder)
            {
                if (string.IsNullOrWhiteSpace(FolderPath))
                {
                    throw new ArgumentException("A source folder must be supplied when converting a folder");
                }

                if (!Path.Exists(FolderPath))
                {
                    throw new ArgumentException($"The source folder \"{FolderPath}\" does not exist");
                }
            }

            if (!ConvertFolder)
            {
                if (string.IsNullOrWhiteSpace(FileName))
                {
                    throw new ArgumentException("A source file must be supplied when converting a file");
                }

                if (!Path.Exists(FileName))
                {
                    throw new ArgumentException($"The source file \"{FileName}\" does not exist");
                }
            }
        }
    }
}
