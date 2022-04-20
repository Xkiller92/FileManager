using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text;
using System.IO;

//games using mono

namespace FileManager.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public ObservableCollection<Folder> items{get; set;}

        public MainWindowViewModel(){

            items = new ObservableCollection<Folder>();

            Folder root = new Folder("root", "/home/calorine92"); 

            root.folders = GetDirectoriesFromRoot(root.Path);            

            items.Add(root);
        }   

        ObservableCollection<Folder> GetDirectoriesFromRoot(string path){
            
            var dirs = Directory.GetDirectories(path);
            ObservableCollection<Folder> f = new ObservableCollection<Folder>();

            if (dirs.Length != 0)
            {
                foreach (var dir in dirs)
                {
                    Folder o = new Folder(dir, dir);
                    o.folders = GetDirectoriesFromRoot(o.Path);
                    f.Add(o);
                }
            }

            return f;
        }
    }
}
