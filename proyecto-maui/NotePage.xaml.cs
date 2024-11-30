namespace proyecto_maui
{
    public partial class NotePage : ContentPage
    {
        private readonly string _fileName = Path.Combine(FileSystem.AppDataDirectory, "notes.txt");

        public NotePage()
        {
            InitializeComponent();
            
            if (File.Exists(_fileName))
                TextEditor.Text = File.ReadAllText(_fileName);
        }
    }
}
