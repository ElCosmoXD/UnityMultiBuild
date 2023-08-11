using UnityEngine;
using System.IO;
using System.Collections.Generic;

namespace MultiBuild
{

    // Our own enumeration of targets so we can serialize with confidence
    // in case Unity changes the values of their internal targets
    public enum Target
    {
        Win32 = 0,
        Win64 = 1,
        Mac64 = 2,
        Linux64 = 3,
        iOS = 4,
        Android = 5,
        WebGL = 6,
        WinStore = 7,
        PS4 = 8,
        XboxOne = 9,
        Switch = 10,
    }

    public class Settings : ScriptableObject
    {

        public string outputFolder;
        public bool useProductName;
        public string overrideName;
        public bool developmentBuild;
        public List<Target> targets;

        public void Reset()
        {
            outputFolder = Directory.GetParent(Application.dataPath).FullName;
            useProductName = true;
            overrideName = string.Empty;
            developmentBuild = false;
            targets = new List<Target>();
        }
    }
}
