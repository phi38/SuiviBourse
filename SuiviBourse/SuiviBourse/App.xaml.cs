using SuiviBourse.DataSource;
using SuiviBourse.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace SuiviBourse
{
	public partial class App : Application
	{
        private static AlerteBourseDB database;

        public App ()
		{
			InitializeComponent();

            //MainPage = new SuiviBourse.MainPage();
            MainPage = new NavigationPage(new SuiviBourse.View.AlerteListViewPage());
        }

        public static AlerteBourseDB Database
        {
            get
            {
                if (database == null)
                {
                    //FileHelper f = new FileHelper();
                    string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                    ;
                    database = new AlerteBourseDB(Path.Combine(path, "AlerteBourseDB_SQLite.db3"));
                    //database = new AlerteBourseDB( f.GetLocalFilePath("AlerteBourseDB_SQLite.db3"));
                }
                return database;
            }
        }

        protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
