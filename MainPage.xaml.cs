namespace prueba_de_proyecto
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();

            // Cargar datos en el ListView (esto es solo un ejemplo)
            listView.ItemsSource = new List<Item>
            {
                new Item { Name = "Games Plus", Description = "" },
                new Item { Name = "Zapateria Centro tgu.", Description = "" },
                new Item { Name = "Encomiendas rapidas", Description = "" }
            };
        }
    }

    public class Item
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}