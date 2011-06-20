using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Tomodoro.Data
{
    /// <summary>
    /// Provides functions for reading/writing items to disk, searching, syncing to cloud
    /// Also includes data structure for overall
    /// </summary>
    public class TomodoriRepository
    {
        private TomodoriRepository()
        {
            _Workdays = new List<Workday>();

        }

        
        private List<Workday> _Workdays;
        public List<Workday> Workdays
        {
            get
            {
                return _Workdays;
            }
        }

        private Dictionary<DateTime, Workday> _WorkdayLookup;
        public Workday GetWorkday(DateTime date)
        {
            if (_WorkdayLookup == null)
            {
                GenerateLookup();
            }

            if (!_WorkdayLookup.ContainsKey(date.Date))
            {
                _Workdays.Add(new Workday { Date = date.Date });
                GenerateLookup();

            }     
           
            return _WorkdayLookup[date.Date];
        }

        private void GenerateLookup()
        {
            _WorkdayLookup = new Dictionary<DateTime, Workday>();
            foreach (var day in _Workdays)
            {
                _WorkdayLookup.Add(day.Date.Date, day);
            }
        }

        public static TomodoriRepository LoadFromFile(string Filepath)
        {
            TomodoriRepository returnable;

            if (!File.Exists(Filepath))
                return new TomodoriRepository();
            
            System.Xml.Serialization.XmlSerializer ser = new System.Xml.Serialization.XmlSerializer(typeof(TomodoriRepository));

            FileStream fstream = new FileStream(Filepath, FileMode.Open);

            returnable = (TomodoriRepository)ser.Deserialize(fstream);

            fstream.Flush();
            fstream.Close();

            returnable.GenerateLookup();
            return returnable;
        }

        public static void WriteToFile(string Filepath, TomodoriRepository Repository)
        {
            FileInfo finfo = new FileInfo(Filepath);
            Directory.CreateDirectory(finfo.DirectoryName);

            System.Xml.Serialization.XmlSerializer ser = new System.Xml.Serialization.XmlSerializer(Repository.GetType());

            File.Delete(Filepath);
            FileStream fstream = new FileStream(Filepath, FileMode.OpenOrCreate);
            ser.Serialize(fstream, Repository);
            fstream.Flush();
            fstream.Close();
        }
    }
}
