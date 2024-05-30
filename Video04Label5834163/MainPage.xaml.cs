namespace Video04Label5834163
{
    public partial class MainPage : TabbedPage
    {
        
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
        }


        /// <summary>
        /// El boton cambia el texto predeterminado en el XAML a por el del evento clicked en el .cs
        /// </summary>

        private void Button_Clicked(object sender, EventArgs e)
        {
            ((Button)sender).Text = "Presioname de nuevo";
        }

        /// <summary>
        /// Por cada letra escrita llevara a cabo este evento
        /// en el OldText se guardara el texto escrito de primero 
        /// en el NewText se guardara el nuevo texto escrito
        /// </summary>

        private void Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            string pasando = e.OldTextValue;
            string nuevo = e.NewTextValue;
        }

        /// <summary>
        /// En esta ocasion lo que se haya escrito en el Entry se guardara en la variable text
        /// </summary>

        private void Entry_Completed(object sender, EventArgs e)
        {
            string text = ((Entry)sender).Text;
        }
    }

}
