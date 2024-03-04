using MauiAppListaCompras.Helpers;

namespace MauiAppListaCompras
{
    public partial class App : Application
    {
        static SQLiteDatabaseHelper _db;

        public static SQLiteDatabaseHelper Db
        {
            get 
            { 
                if (_db == null)   
                {
                    string path = Path.Combine(
                        Environment.GetFolderPath(
                            Environment.SpecialFolder.LocalApplicationData
                            ), "banco_sqlite_compras.db3"
                            );
                   
                    _db = new SQLiteDatabaseHelper( path );

                }// fecha if verificando se _db é NULL
                
                return _db;
            
            }// Fecha método GET

            
        }
        
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}
