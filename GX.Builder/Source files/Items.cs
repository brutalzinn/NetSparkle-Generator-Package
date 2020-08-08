using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Update.Maker.Source_files
{
    public class Items
    {


        private int _id;
        private string _title;
        private string _file;
        private string _releasenote;
        private string _link;
        private string _version;
        private string _shortversion;
        private string _system;
        private string _type;
        private string _directory;
        private string _criticalupdate;
        private string _changelogpath;
        private string _changelogurl;
        private bool _isprefixed;
        private string _androidversion;
        private string _androidversionmaximum;
        private string _androidversionminimum;

        public void CreateTextBox(int id, string title, string file, string releasenote, string link, string version, string shortversion, string system, string type, string criticalupdate, string changelogpath, string changelogurl, bool isprefixed,string androidversion, string androidversionminum,string androidmaximum)
        {


        }
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        public string File
        {
            get { return _file; }
            set { _file = value; }
        }
        public string Releasenote
        {

            get { return _releasenote; }
            set { _releasenote = value; }

        }
        public string Link
        {

            get { return _link; }
            set { _link = value; }

        }
        public string Version
        {
            get { return _version; }
            set { _version = value; }


        }
        public string Shortversion
        {
            get { return _shortversion; }
            set { _shortversion = value; }
        }
        public string System
        {
            get { return _system; }
            set { _system = value; }
        }
        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }
        public string Criticalupdate
        {
            get { return _criticalupdate; }
            set { _criticalupdate = value; }
        }
        public string Changelogpath
        {
            get { return _changelogpath; }
            set { _changelogpath = value; }
        }
        public string Changelogurl
        {
            get { return _changelogurl; }
            set { _changelogurl = value; }
        }
        public bool Isprefixed
        {
            get { return _isprefixed; }
            set { _isprefixed = value; }
        }

        public string AndroidVersion
        {
            get { return _androidversion; }
            set { _androidversion = value; }
        }
        public string AndroidVersionMaximum
        {
            get { return _androidversionmaximum; }
            set { _androidversionmaximum = value; }
        }
        public string AndroidVersionMinimum
        {
            get { return _androidversionminimum; }
            set { _androidversionminimum = value; }
        }
        public string Directory
        {
            get { return _directory; }
            set { _directory = value; }
        }


    }
}
