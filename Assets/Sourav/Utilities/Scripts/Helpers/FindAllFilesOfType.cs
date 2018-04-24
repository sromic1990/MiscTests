using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

namespace Sourav.Utilities.Scripts.Helpers
{    
    public class FindAllFilesOfType 
    {
        static string[] files;
        
        public static string[] FindAllFiles(string searchPath, FileTypes type, SearchOption option)
        {
            string fileType = "*";
            
            switch(type)
            {
                case FileTypes.cs:
                    fileType = "*.cs";
                    break;
                    
                case FileTypes.jpg:
                    fileType = "*.jpg";
                    break;
                    
                case FileTypes.mp3:
                    fileType = "*.mp3";
                    break;
                    
                case FileTypes.png:
                    fileType = "*.png";
                    break;
                    
                case FileTypes.wav:
                    fileType = "*.wav";
                    break;
                    
                case FileTypes.asset:
                    fileType = "*.asset";
                    break;
                    
                case FileTypes.scene:
                    fileType = "*.unity";
                    break;
                    
                case FileTypes.txt:
                    fileType = "*.txt";
                    break;
                    
                case FileTypes.xml:
                    fileType = "*.xml";
                    break;
                    
                case FileTypes.json:
                    fileType = "*.json";
                    break;
                    
                case FileTypes.dll:
                    fileType = "*.dll";
                    break;
                    
                case FileTypes.docx:
                    fileType = "*.docx";
                    break;
                    
                case FileTypes.pdf:
                    fileType = "*.pdf";
                    break;
            }
            
            files = Directory.GetFiles(Application.dataPath, fileType, option);
            
            return files;
        }
        
    }
    
}

public enum FileTypes
{
    cs,
    png,
    jpg,
    wav,
    mp3,
    asset,
    scene,
    txt,
    json,
    xml,
    dll,
    pdf,
    docx
}
