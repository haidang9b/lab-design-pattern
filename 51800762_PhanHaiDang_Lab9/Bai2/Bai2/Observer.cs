using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    public interface IObserver
    {
        void Update(string message);
    }


    public class Client : IObserver
    {
        public void Update(string message)
        {

            Console.WriteLine(message);
        }
    }
    public class WatcherService
    {
        FileSystemWatcher watcher;
        List<IObserver> observers;
        public WatcherService()
        {
            observers = new List<IObserver>();
            watcher = new FileSystemWatcher(@"D:\Java\Design Pattern\tmp");
            handleConstructor();
        }
        public WatcherService(string path)
        {
            observers = new List<IObserver>();
            watcher = new FileSystemWatcher(path);
            handleConstructor();
        }

        private void handleConstructor()
        {

            watcher.NotifyFilter = NotifyFilters.Attributes
                     | NotifyFilters.CreationTime
                     | NotifyFilters.DirectoryName
                     | NotifyFilters.FileName
                     | NotifyFilters.LastAccess
                     | NotifyFilters.LastWrite
                     | NotifyFilters.Security
                     | NotifyFilters.Size;

            watcher.Changed += OnChanged;
            watcher.Created += OnCreated;
            watcher.Deleted += OnDeleted;
            watcher.Renamed += OnRenamed;
            watcher.Error += OnError;

            watcher.Filter = "*.*";
            watcher.IncludeSubdirectories = true;
            watcher.EnableRaisingEvents = true;
        }
        public void AddObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void NotifyChanged(string value)
        {
            foreach(var obs in observers){
                obs.Update(value);
            }
        }
        private void OnChanged(object sender, FileSystemEventArgs e)
        {

            if (e.ChangeType != WatcherChangeTypes.Changed)
            {
                return;
            }
            string value = $"Changed: {e.FullPath}";
          
            NotifyChanged(value);
        }

        private void OnCreated(object sender, FileSystemEventArgs e)
        {
            string value = $"Created: {e.FullPath}";
            NotifyChanged(value);
        }

        private void OnDeleted(object sender, FileSystemEventArgs e)
        {
            string value = $"Deleted: {e.FullPath}";
            NotifyChanged(value);
        }
            


        private void OnRenamed(object sender, RenamedEventArgs e)
        {
            string value = $"Renamed:     Old: {e.OldFullPath}    New: {e.FullPath}";
            NotifyChanged(value);
        }

        private void OnError(object sender, ErrorEventArgs e) =>
            PrintException(e.GetException());

        private void PrintException(Exception ex)
        {
            if (ex != null)
            {

                string value = $"Message: {ex.Message}\n" + "Stacktrace: " + ex.StackTrace;
                NotifyChanged(value);
                PrintException(ex.InnerException);
            }
        }
        

    }
}
