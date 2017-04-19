using RoutePackage.Models.Database;
using RoutePackage.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace RoutePackage
{
    public partial class App : Application
    {
        public static double ScreenHeight;
        public static double ScreenWidth;

        //public DBContext Contexto { get; set; }

        public App()
        {
            //Contexto = new DBContext();

            InitializeComponent();

            SetMainPage();
        }

        protected override void OnStart()
        {
            //Contexto.Configurar<SearchPlaceDB>();
        }

        public static void SetMainPage()
        {
            Current.MainPage = new TabbedPage
            {
                Children =
                {
                    new NavigationPage(new MapPage())
                    {
                        Title = "Buscar",
                        Icon = Device.OnPlatform("tab_feed.png",null,null)
                    },
                    new NavigationPage(new AddNewPlace())
                    {
                        Title = "Nuevos lugares",
                        Icon = Device.OnPlatform("tab_about.png",null,null)
                    },
                    new NavigationPage(new ItemsPage())
                    {
                        Title = "Anteriores",
                        Icon = Device.OnPlatform("tab_about.png",null,null)
                    }

                }
            };
        }
    }
}
