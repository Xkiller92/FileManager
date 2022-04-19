using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

public class Folder
{
    public string Name{get; set;}
    public string Path{get; set;}
    public ObservableCollection<Folder> folders{get; set;}

    public Folder(string name, string path)
    {
        Name = name;
        Path = path;
        folders = new ObservableCollection<Folder>();
    }
}