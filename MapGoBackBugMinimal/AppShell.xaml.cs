namespace MapGoBackBugMinimal
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute("MapPage", typeof(MapPage));
        }
    }
}
