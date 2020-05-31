using System;
using System.IO;

using Foundation;

using UIKit;

namespace ImportDbFile.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        //
        // This method is invoked when the application has loaded and is ready to run. In this 
        // method you should instantiate the window, load the UI into it and then make the window
        // visible.
        //
        // You have 17 seconds to return from this method, or iOS will terminate your application.
        //
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init();

            string docFolder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);

            if (!Directory.Exists(docFolder))
            {
                Directory.CreateDirectory(docFolder);
            }

            string dbPath = Path.Combine(docFolder, "TEST.db");

            CopyDatabaseIfNotExists(dbPath);

            LoadApplication(new App());

            return base.FinishedLaunching(app, options);
        }

        #region CopyDatabaseIfNotExists(dbPath)

        /// <summary>
        /// 해당 경로에 DB 파일을 복사합니다.
        /// </summary>
        /// <param name="dbPath">db파일 경로</param>
        private void CopyDatabaseIfNotExists(string dbPath)
        {
            if (!File.Exists(dbPath))
            {
                var existingDb = NSBundle.MainBundle.PathForResource("TEST", "db");
                File.Copy(existingDb, dbPath);
            }
        }

        #endregion
    }
}
