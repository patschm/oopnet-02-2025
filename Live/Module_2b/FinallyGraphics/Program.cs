namespace FinallyGraphics
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());

            //Form form = new Form();
            //form.Text = "Hello Form";
            //form.Width = 600;
            //form.Height = 400;


            //Button button = new Button();
            //button.Location = new Point(100, 100);
            //button.Text = "Click Me!";

            //button.Click += ClickHandler;

            //form.Controls.Add(button);

            //form.ShowDialog();
        }

        static void ClickHandler(object? sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.Parent.BackColor = Color.Red;
        }
    }
}